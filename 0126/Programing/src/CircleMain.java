import java.util.Scanner;

public class CircleMain {

   public static void main(String[] args) {
      // TODO Auto-generated method stub
      Circle circle = new Circle(3.14);
      Scanner s = new Scanner(System.in);
      
      System.out.println("반지름입력: ");
      Circle.rad=s.nextInt();
      
      System.out.println("반지름:"+Circle.rad);
      System.out.println("넓이:" +circle.getArea());
   }

}