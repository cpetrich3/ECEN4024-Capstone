class MyClass() {

    string myString = "Hello world";
    private int num1 = 20;
    private int num2 = 30;
    string myString2 = "Hello world";

    public int getNum1() {
        return num1;
    }
}

class Test {
    static void Main(){
        MyClass myClass = new MyClass();
        Console.Write(myClass.getNum1());
    }
}
