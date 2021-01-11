package func;

import java.util.Arrays;
import java.util.Scanner;

public class Que {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int arr[] = new int[3];
		for (int i = 0; i < 3; i++) {
			arr[i] = s.nextInt();
			}
		num(arr); 
		for (int i = 0; i < arr.length; i++) {
			System.out.print(arr[i]);
			System.out.print(" ");
		}
	}
	public static void num(int arr[]) {
		Arrays.sort(arr);
	}
}