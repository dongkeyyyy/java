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
		String last[] = { "��", "��", "��", "��", "��" };
		String first[] = { "��", "��", "��", "��", "��" };
		String mid[] = { "��", "��", "��", "��", "��" };
		System.out.println("--------------- ---------");
		System.out.println("���� ���� ���α׷� v1.1");
		System.out.println("-------------------------");
		System.out.println("1. �̸� �����Ͽ� ���Ͽ� �����ϱ�");
		System.out.println("2. ���Ͽ��� �̸� �о����");
		System.out.println("3. ���α׷� ����");
		System.out.println("-------------------------");
		System.out.println("�޴� ���� : ");
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
				System.out.println("���ϸ� : " + fileName);
				System.out.println("���ϳ��� : " + str);
				System.out.println("���� ������ �����Ͽ����ϴ�.");
				break;
			case 2:
				System.out.println("2. ���� �б�");
				System.out.println("���ϸ� : array_fullName.txt");
				System.out.println("�д� ���� : ���� ���� �׽�Ʈ�Դϴ�.");
				System.out.println("���� �бⰡ �����Ͽ����ϴ�.");
				break;
			case 3:
				System.out.println(" ���� ");
				s.close();
				System.exit(0);
			default:
				System.out.println("�߸� �Է� �ϼ̽��ϴ�.");
			}
		}

	}

}
