package operTest_1208;

import java.util.Scanner;

public class Homework {

	public static void main(String[] args) {
		int a = 0; // 500원
		int b = 0; // 100원
		int c = 0; // 50원
		int d = 0; // 10원
		
		System.out.println("교환할 금액 : ");
		
		Scanner s = new Scanner(System.in);
		int e = s.nextInt(); // 동전 교환할  금액
		
		a = 500;  b = 100;  c = 50;   d = 10;
		
		int num1 = e / a; 
		int num2 = (e % a) / b;
		int num3 = (e % a % b) / c;
		int num4 = (e % a % b % c) / d;
		int num5 = e % a % b % c % d;
		
		System.out.println("----------------------------");
		System.out.println("    동전 교환기 프로그램 1.0     ");
		System.out.println("----------------------------");
		System.out.println("  오백원 갯수 : " + num1 + "개"  );
		System.out.println("   백원 갯수 : " + num2 + "개"  );
		System.out.println("  오십원 갯수 : " + num3 + "개" );
		System.out.println("  십원 갯수 : " + num4 + "개"   );
		System.out.println("바꾸지 못한 잔돈 : " + num5 + "개");
		System.out.println("----------------------------");
		
		
		
		
		

	}

}
