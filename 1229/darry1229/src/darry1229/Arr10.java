package darry1229;

import java.io.BufferedOutputStream;
import java.util.Scanner;

public class Arr10 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		String last[] = {"��", "��", "��", "��" , "��"};
		String first[] = { "��", "��", "��", "��", "��" };
		String mid[] = { "��", "��", "��", "��", "��" };
		String fullName[] = new String[50];
		
		while (true) {
			System.out.println("--------------- ---------");
			System.out.println("���� ���� ���α׷� v1.1");
			System.out.println("-------------------------");
			System.out.println("1. �̸� �����Ͽ� ���Ͽ� �����ϱ�");
			System.out.println("2. ���Ͽ��� �̸� �о����");
			System.out.println("3. ���α׷� ����");
			System.out.println("-------------------------");
			System.out.println("�޴� ���� : ");
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
				System.out.println("1. �̸� �����Ͽ� ���Ͽ� �����ϱ�");
				break;
			case 2:
				System.out.println("2. ���� �б�");
				break;
			case 3:
				System.out.println("���α׷� ����!");
				s.close();
				System.exit(0);
			default:
				System.out.println("�߸� �Է��ϼ̽��ϴ�");
			}

		}

	}

}
