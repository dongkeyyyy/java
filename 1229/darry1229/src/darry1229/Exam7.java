package darry1229;

import java.io.BufferedOutputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Scanner;
import java.util.StringTokenizer;

public class Exam7 {

	public static void main(String[] args) throws IOException {
		Scanner s = new Scanner(System.in);
		final String last[] = { "��", "��", "��", "��", "��" };
		final String first[] = { "��", "��", "��", "��", "��" };
		final String mid[] = { "��", "��", "��", "��", "��" };
		final String fileName = "d:/array_fullName.txt";
		String[] fullName = new String[50];
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
				BufferedOutputStream bs = null;
				bs = new BufferedOutputStream(new FileOutputStream(fileName));
				for (int i = 0; i < fullName.length; i++) {
					int rand = (int) (Math.random() * 5);
					fullName[i] = last[(int) (Math.random() * 5)] + mid[(int) (Math.random() * 5)]
							+ first[(int) (Math.random() * 5)];
					bs.write(fullName[i].getBytes());
					bs.write("/".getBytes());
//					fullName[i] = last[rand] + mid[rand] + first[rand];
//					System.out.println(fullName[i]);
				}
				bs.close();
				System.out.println("���� ���� ����!");
				break;
			case 2:
				String str = "ȫ�浿 / ��浿 / �ֱ浿";
				StringTokenizer stk = new StringTokenizer(str, "/");
				while (stk.hasMoreTokens()) {
					System.out.println(stk.nextToken());
				}
				break;
			case 3:
				s.close();
				System.exit(0);
				break;
			default:
				System.out.println("�߸��� �޴� ����!");
				break;
			}
		}
	}

}
