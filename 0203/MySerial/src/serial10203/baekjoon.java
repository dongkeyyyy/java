package serial10203;

import java.util.Scanner;

public class baekjoon {

	public static void main(String[] args) {
		int A = 5;
		int B = 8;
		int C = 4;

		System.out.println((A + B) % C);
		System.out.println(((A % C) + (B % C)) % C);
		System.out.println((A * B) % C);
		System.out.println(((A % C) * (B % C)) % C);

	}

}
