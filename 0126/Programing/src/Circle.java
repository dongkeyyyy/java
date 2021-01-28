public class Circle {
 static double rad = 0;
 final double PI = 3.14;
 
 public Circle(double rad) {
    this.rad =rad;
   
}
public double getRad(double rad) {
   return rad;   
}
public void setRad(double rad) {
   this.rad=rad;
}

public double getArea() {
   return PI*rad*rad;
}
}