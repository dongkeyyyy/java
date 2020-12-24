package hack4ork;

import java.io.BufferedOutputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Random;
import java.util.Scanner;

public class Exam7 {

	public static void main(String[] args) {
		String fullName[] = new String[50];
		Scanner s = new Scanner(System.in);
		Random rand = new Random();
		String last[] = { "김", "박", "이", "최", "장" };
		String first[] = { "바", "사", "아", "자", "차" };
		String mid[] = { "가", "나", "다", "라", "마" };
		System.out.println("--------------- ---------");
		System.out.println("파일 제어 프로그램 v1.1");
		System.out.println("-------------------------");
		System.out.println("1. 이름 생성하여 파일에 저장하기");
		System.out.println("2. 파일에서 이름 읽어오기");
		System.out.println("3. 프로그램 종료");
		System.out.println("-------------------------");
		System.out.println("메뉴 선택 : ");
		int menu = s.nextInt();

		for (int i = 0; i < 50; i++) {
			String lastName = last[rand.nextInt(5)];
//			System.out.print(lastName);
			String firstName = first[rand.nextInt(5)];
//			System.out.print(firstName);
			String midName = mid[rand.nextInt(5)];
//			System.out.print(midName);
//			System.out.println();
			fullName[i] = lastName + firstName + midName;
		
			switch (menu) {
			case 1:
				BufferedOutputStream bs = null;
				String str = null;
				String fileName = "d:/array_fullName.txt";
				try {
					bs = new BufferedOutputStream(new FileOutputStream(fileName));
					str = fullName[i];
					bs.write(str.getBytes());
					bs.close();
				} catch (FileNotFoundException e) {
					e.printStackTrace();
				} catch (IOException e) {
					e.printStackTrace();
				}
				System.out.println("파일명 : " + fileName);
				System.out.println("파일내용 : " + str);
				System.out.println("파일 생성이 성공하였습니다.");
				break;
			case 2:
				System.out.println("2. 파일 읽기");
				System.out.println("파일명 : array_fullName.txt");
				System.out.println("읽는 내용 : 파일 생성 테스트입니다.");
				System.out.println("파일 읽기가 성공하였습니다.");
				break;
			case 3:
				System.out.println(" 종료 ");
				s.close();
				System.exit(0);
			default:
				System.out.println("잘못 입력 하셨습니다.");
			}
		}

	}

}
