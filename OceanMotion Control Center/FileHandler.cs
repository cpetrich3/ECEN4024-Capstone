using System.IO;

namespace OceanMotion;

public class FileHandler() {
    
    private StreamReader sr;
    private StreamWriter sw;

    public int ValidateFile(String path) {
        return ReadFile(path);
    }

    private int ReadFile(String path) {
        String line1;
        String line2;
        try {
            // REFACTOR***
            sr = new StreamReader(path);
            line = sr.ReadLine();
            while ((line = sr.ReadLine()) != null) {
                Validate(line);
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
    private int Validate(String line) {
        return 0;
    }
}