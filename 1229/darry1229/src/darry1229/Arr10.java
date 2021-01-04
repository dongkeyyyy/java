package darry1229;

import java.io.BufferedOutputStream;
import java.util.Scanner;

public class Arr10 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		String last[] = {"김", "박", "이", "최" , "장"};
		String first[] = { "바", "사", "아", "자", "차" };
		String mid[] = { "가", "나", "다", "라", "마" };
		String fullName[] = new String[50];
		
		while (true) {
			System.out.println("--------------- ---------");
			System.out.println("파일 제어 프로그램 v1.1");
			System.out.println("-------------------------");
			System.out.println("1. 이름 생성하여 파일에 저장하기");
			System.out.println("2. 파일에서 이름 읽어오기");
			System.out.println("3. 프로그램 종료");
			System.out.println("-------------------------");
			System.out.println("메뉴 선택 : ");
			int menu = s.nextInt();
			switch (menu) {
			case 1:
				
					System.out.println(fullName[i]);
				}
				BufferedOutputStream bs = null;
				String str = null;
				String fileName = "d:/array_fullName.txt";
				try {
					bs = new BufferedOutputStream(new FileOutputStream(fileName));
					for (int i = 0; int < 50; i++) {
						bs.write(fullName[i].getBytes());
					}
					bs.write(str.getBytes());
					bs.close();
				} catch (FileNotFoundException e) {
					e.printStackTrace();
				} catch (IOException e) {
					e.printStackTrace();
				}
				System.out.println("1. 이름 생성하여 파일에 저장하기");
				break;
			case 2:
				System.out.println("2. 파일 읽기");
				break;
			case 3:
				System.out.println("프로그램 종료!");
				s.close();
				System.exit(0);
			default:
				System.out.println("잘못 입력하셨습니다");
			}

		}

	}

}
