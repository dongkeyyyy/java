package answer1228;

import java.util.Arrays;
import java.util.Scanner;

public class One {

	public static void main(String[] args) {
		// ���� N���� �Է¹޾� ���߿� ū���� ������ ���
		System.out.println("1�� ����");
		Scanner s = new Scanner(System.in);
		System.out.println("�� �� ���� ���ڸ� �Է¹�����?");
		int countNum = s.nextInt();
		System.out.println("���� ���ڵ��� �Է¹޴´�");
		int[] numberList = new int[countNum];

		for (int i = 0; i < countNum; i++) {
			numberList[i] = s.nextInt();
		}

		// �ִ� �ּҸ� ��
		// ù��° ���
		int max = numberList[0];
		int min = numberList[0];

		for (int i = 0; i < numberList.length; i++) {
			if (numberList[i] > max)
				max = numberList[i];
			if (numberList[i] < min)
				min = numberList[i];
		}
		System.out.println("�ּڰ� : " + min);
		System.out.println("�ִ� : " + max);
		
		// �ι�° ���
		Arrays.sort(numberList);
		System.out.println("�ּڰ� : " + numberList[0]);
		System.out.println("�ִ� : " + numberList[numberList.length-1]);

	}

}
