import java.util.Scanner;

public class Input4 {

	public static void main(String[] args) {
		
		Scanner s = new Scanner(System.in);
		
		
		System.out.println("국어 점수 입력 : ");
		double g = s.nextDouble();
		
		System.out.println("영어 점수 입력 : ");
		double e = s.nextDouble();
		
		System.out.println("수학 점수 입력 : ");
		double m = s.nextDouble();
		
		System.out.println("과학 점수 입력 : ");
		double t = s.nextDouble();
		
		System.out.println("평균값 : " + (g+e+m+t)/4);
		
		System.out.println("총점 : " + (g+e+m+t));
	
	}

}










// TODO Auto-generated method stub
//		Scanner s = new Scanner(System.in);

//		System.out.println("원주율 입력: ");
//		double pi = s.nextDouble();

//		System.out.println("반지름 입력: ");
//		double ban = s.nextDouble();

//		double one = ban * ban * pi ;


//		System.out.println("원의 면적 : " + one);
