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
		String last[] = { "��", "��", "��", "��", "��" };
		String first[] = { "��", "��", "��", "��", "��" };
		String mid[] = { "��", "��", "��", "��", "��" };
		String fullName[] = new String[50];
		while (true) {
			System.out.println("-------------------------");
			System.out.println("���� ���� ���α׷� v1.1");
			System.out.println("-------------------------");
			System.out.println("1. �̸� �����Ͽ� ���Ͽ� �����ϱ�");
			System.out.println("2. ���Ͽ��� �̸� �о����");
			System.out.println("3. ���α׷� ����");
			System.out.println("�޴� ���� : ");
			int menu = s.nextInt();
			switch (menu) {
			case 1 : 
				System.out.println("1. �̸� �����Ͽ� ���Ͽ� �����ϱ�");
				break;
			case 2 : 
				System.out.println("2. ���� �б�");
				break;
			case 3 : 
				System.out.println("���α׷� ����!");
				s.close();
				System.exit(0);
				default : System.out.println("�߸� �Է��ϼ̽��ϴ�");
			}
		}
		
		
		
	}

}










// ����ִ� 2*3 �迭 ����
//int arr[][] = new int[2][3]; 
//
//arr[0][0] = 10;
//arr[1][2] = 100;
//
//System.out.println(arr[0][0]);
//System.out.println(arr[1][2]);
