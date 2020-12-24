package array;

import java.util.Scanner;

public class Arr2 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int[] arr = new int[3];
		int hap = 0;
		
		System.out.print("1번째 숫자 입력 : ");
		arr[0] = s.nextInt();
		System.out.print("2번째 숫자 입력 : ");
		arr[1] = s.nextInt();
		System.out.print("3번째 숫자 입력 : ");
		arr[2] = s.nextInt();
		
		hap = arr[0] + arr[1] + arr[2];
		System.out.println("배열의 합 : " + hap);
		
		hap = 0;   //위에서 사용했으므로 최고하해준다
		for (int i = 0; i<3; i++) {   // 반복문을 이용한 배열의 합 
			hap += arr[i]; // hap = hap + arr[i]
		}
		System.out.println("배열의 합 : " + hap);
		
		s.close();
		//배열의 크기는 1부터 읽으므로 3이지만 읽을때는 0부터 읽으므로 최대가 2이다.
	}

}
