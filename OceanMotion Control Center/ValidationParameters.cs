namespace OceanMotion;

public class ValidationParameters() {
    private double maxHeight;
    private double minHeight;
    private double maxVelocity;
    private double minTimeStep;
    //private int maxAcceration; not sure if this one is necessary yet
    // ... add more as needed

    public ValidationParameters(double maxHeight, double minHeight, double maxVelocity, double minTimeStep) {
        this.maxHeight = maxHeight;
        this.minHeight = minHeight;
        this.maxVelocity = maxVelocity;
        this.minTimeStep = minTimeStep;
    }

    public int getMaxHeight() {
        return this.maxHeight;
    }

    public int getMinHeight() {
        return this.minHeight;
    }

    public int getMaxVelocity() {
        return this.maxVelocity;
    }

    public int getMinTimeStep() {
        return this.minTimeStep;
    }
}
