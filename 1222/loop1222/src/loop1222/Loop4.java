package loop1222;

import java.util.Scanner;

public class Loop4 {

	public static void main(String[] args) {
		for (int i = 2; i < 10; i++) {
			for (int j = 0; j < 9; j++) {
				System.out.printf("%d * %d = %d\n", i, (j + 1), i * (j + 1));
			}
		}

//		Scanner s = new Scanner(System.in);
//		System.out.println("입력한 숫자의 구구단 : ");
//		int j = s.nextInt();
//
//		for (int i = 0; i < 9; i++) {
//			System.out.printf("%d * %d = %d\n", j, i+1, j*(i+1));
//			s.close();
//		}

	}

}
