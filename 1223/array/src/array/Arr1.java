package array;

import java.util.Scanner;

public class Arr1 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int[] arr = new int[3];
		int hap = 0;

		for (int i = 0; i < 3; i++) {
			System.out.print((i + 1) + "번째 숫자 입력 :");
			arr[i] = s.nextInt();
		}

		for (int i = 0; i < 3; i++) { // 반복문을 이용한 배열의 합
			hap += arr[i]; // hap = hap + arr[i]
		}
		System.out.println("배열의 합 : " + hap);

		s.close();
		// 배열의 크기는 1부터 읽으므로 3이지만 읽을때는 0부터 읽으므로 최대가 2이다.
	}

}
