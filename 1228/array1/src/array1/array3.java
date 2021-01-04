package array1;

import java.util.Scanner;

public class array3 {

	public static void main(String[] args) {
		int a, b, c;
		int sum;
		int[] arr = new int[10]; // 0~9 숫자들의 쓰인 횟수를 저장할 배열

		Scanner sc = new Scanner(System.in);
		a = sc.nextInt();
		b = sc.nextInt();
		c = sc.nextInt();
		
		sum = a*b*c; // 다 곱한 값
		
		while(sum!=0) { // sum이 0일때까지 반복
			arr[sum%10]++; // 일의자리 숫자에 해당하는 인덱스의 배열 값 증가
			sum = sum / 10; // 일의자리 숫자를 버림
		}
		
		for(int j=0; j<10; j++) {
			System.out.println(arr[j]); // 숫자들이 쓰인 횟수를 출력
		}



	}

}
