package loop1222;

import java.io.BufferedOutputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Scanner;

public class Loop5 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		while (true) {
			System.out.println("-------------------------");
			System.out.println("������ ���� ���� ���α׷� v1.0");
			System.out.println("-------------------------");
			System.out.println("1. ���� ���� �� ����");
			System.out.println("2. ���� �б�");
			System.out.println("3. ���α׷� ����");
			System.out.println("---------------------");
			System.out.println("�޴��� �����ϼ���: ");
			int menu = s.nextInt();

			switch (menu) {
			case 1:
				BufferedOutputStream bs = null;
				String str = null;
				String fileName = "d:/test1.txt";
				try {
					bs = new BufferedOutputStream(new FileOutputStream(fileName));
					str = "���� ���� �� ���� �����Դϴ�.";
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
				System.out.println("���ϸ� : test1.txt");
				System.out.println("�д� ���� : ���� ���� �׽�Ʈ�Դϴ�.");
				System.out.println("���� �бⰡ �����Ͽ����ϴ�.");
				break;
			case 3:
				System.out.println(" ���� ");
				s.close();
				System.exit(0);
				break; // �� break�� system.exit(0); �� �����Ƿ� ������ ������ ����� ���� �ʴ´�.
			default:
				System.out.println("�߸� �Է� �ϼ̽��ϴ�.");
			}
		}
	}

}
