package test_0104;

import java.util.Scanner;

public class Test_6 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int N = s.nextInt();
		int M = s.nextInt();
		int result = 0;
		for (int i = 1; i <= N; i++) {
			if (i % M != 0) {
				result = result + i;
			}

		}
		System.out.println(result);
	}

}
