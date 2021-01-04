package darry1229;

import java.io.BufferedOutputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Random;
import java.util.Scanner;

public class Arr1 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		Random rand = new Random();
		String last[] = { "김", "박", "이", "최", "장" };
		String first[] = { "바", "사", "아", "자", "차" };
		String mid[] = { "가", "나", "다", "라", "마" };
		String fullName[] = new String[50];
		while (true) {
			System.out.println("-------------------------");
			System.out.println("파일 제어 프로그램 v1.1");
			System.out.println("-------------------------");
			System.out.println("1. 이름 생성하여 파일에 저장하기");
			System.out.println("2. 파일에서 이름 읽어오기");
			System.out.println("3. 프로그램 종료");
			System.out.println("메뉴 선택 : ");
			int menu = s.nextInt();
			switch (menu) {
			case 1 : 
				System.out.println("1. 이름 생성하여 파일에 저장하기");
				break;
			case 2 : 
				System.out.println("2. 파일 읽기");
				break;
			case 3 : 
				System.out.println("프로그램 종료!");
				s.close();
				System.exit(0);
				default : System.out.println("잘못 입력하셨습니다");
			}
		}
		
		
		
	}

}










// 비어있는 2*3 배열 생성
//int arr[][] = new int[2][3]; 
//
//arr[0][0] = 10;
//arr[1][2] = 100;
//
//System.out.println(arr[0][0]);
//System.out.println(arr[1][2]);
