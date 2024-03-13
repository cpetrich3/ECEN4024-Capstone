using System.IO;

namespace OceanMotion;

public class FileHandler {
    
    private StreamReader sr;
    private StreamWriter sw;


    public int ValidateFile(String path, int maxHeight, int minHeight, int maxVelocity, double minTimeStep) {
        ValidationParameters valParams = new ValidationParameters(maxHeight,minHeight,maxVelocity, minTimeStep);
        return ReadFile(path, valParams);
    }

    private int ReadFile(String path, ValidationParameters valParams) {
        String[] line1;
        String[] line2;
        int stopCode = 1;
        try {
            // REFACTOR***
            sr = new StreamReader(path);
            line1 = sr.ReadLine().Split('\t');
            line2 = sr.ReadLine().Split('\t');
            double time;
            if (line1.Length != 7 || line1.Length != 2) { // Catches if the file isn't in the proper format. Either 7 (time + 6-dof) or 2 (time + heave) columns.
                // Return err# for improper data file format
                return -3;
            } else if (!double.TryParse(line1[0],out time) && double.TryParse(line2[0],out time)) { // Catches if the file has headers and corrects for it.
                line1 = line2; // Increments line1 without further parsing. Line2 will be incremented automatically by the loop.
                line2 = sr.ReadLine().Split('\t');
            }
            
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
        catch(Exception e) {
            //catch other errors
            return -3;
        }
        return 0;
    }
    private int Validate(String[] line1, String[] line2, ValidationParameters valParams) {
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