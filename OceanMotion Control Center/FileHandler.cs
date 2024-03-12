using System.IO;

namespace OceanMotion;

public class FileHandler() {
    
    private StreamReader sr;
    private StreamWriter sw;


    public int ValidateFile(String path, int maxHeight, int minHeight, int maxVelocity) {
        ValidationParameters valParams = new ValidationParameters(maxHeight,minHeight,maxVelocity);
        return ReadFile(path, valParams);
    }

    private int ReadFile(String path, ValidationParameters valParams) {
        String line1;
        String line2;
        int stopCode;
        try {
            // REFACTOR***
            sr = new StreamReader(path);
            line1 = sr.ReadLine();
            while ((line2 = sr.ReadLine()) != null && stopCode == 1) {

                stopCode = Validate(line1.Split('\t'), line2.Split('\t'), valParams); // Will read file lines until completion, or a line occurs that defies the maximums set.
                line1 = line2;
                line2 = sr.ReadLine();
            }
        }
        catch(FileNotFoundException e) {
            // Log & display error
            return -1;
        }
        catch(IOException e) { // Triggered when file is empty I believe
            // Log & display error
            return -2;
        }
        return 0;
    }
    private int Validate(String[] line1, String[] line2, ValidationParameters valParams) {
        if (line1.Length() != 7 && line1.Length() != 2) { // Implies the file has 7 params (time + 6 Dof), or 2 params (time + heave)
            return -1; // improper data file format err# here
        } else if(!double.TryParse(line1[0]) && double.TryParse(line2[0])) {
            return 1; // Table likely has headers, skipping first line.
        }
        double period;
        int fileType; // Will want to include some info on which type of file this is: 1 dof or 6 dof.
        try {
            period = double.Parse(line2[0])-double.Parse(line1[0]);
            if (period < valParams.getMinTimeStep()) {
                return -2; // Timestep is too small.
            }
        } catch(Exception e) {
            return -1; // improper data format err# here
        }
        return 0;
    }
}