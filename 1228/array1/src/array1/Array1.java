package array1;

import java.util.Scanner;

public class Array1 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int ab = s.nextInt();
		int[] abc = new int[ab];
		int index = 0;

		for (int i = 0; i < ab; i++)
			abc[i] = s.nextInt();

		int max = abc[0];
		int min = abc[0];
		for (int i = 0; i < ab; i++) {
			if (abc[i] > max)
				index = i + 1;
			max = abc[i];

			if (abc[i] < min)
				min = abc[i];
		}
		System.out.println(min);
		System.out.println(index);

		s.close();

	}

}
