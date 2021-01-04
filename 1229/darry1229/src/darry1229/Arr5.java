package darry1229;

import java.util.Scanner;

public class Arr5 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		
		System.out.println("----------------");
		System.out.println("구구단 프로그램 v1.0");
		System.out.println("----------------");
		System.out.println("   구구단 입력   : ");
		int A = s.nextInt();
		int value = 0;
		
		int arr[] = new int [9];
		for (int i = 0; i < arr.length; i++) {
			value = A*(i+1);
			System.out.printf("%d * % d = %d\n", A, i+1, value);
		}
		s.close();

	}

}
