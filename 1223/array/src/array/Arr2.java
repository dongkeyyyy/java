package array;

import java.util.Scanner;

public class Arr2 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int[] arr = new int[3];
		int hap = 0;
		
		System.out.print("1��° ���� �Է� : ");
		arr[0] = s.nextInt();
		System.out.print("2��° ���� �Է� : ");
		arr[1] = s.nextInt();
		System.out.print("3��° ���� �Է� : ");
		arr[2] = s.nextInt();
		
		hap = arr[0] + arr[1] + arr[2];
		System.out.println("�迭�� �� : " + hap);
		
		hap = 0;   //������ ��������Ƿ� �ְ������ش�
		for (int i = 0; i<3; i++) {   // �ݺ����� �̿��� �迭�� �� 
			hap += arr[i]; // hap = hap + arr[i]
		}
		System.out.println("�迭�� �� : " + hap);
		
		s.close();
		//�迭�� ũ��� 1���� �����Ƿ� 3������ �������� 0���� �����Ƿ� �ִ밡 2�̴�.
	}

}
