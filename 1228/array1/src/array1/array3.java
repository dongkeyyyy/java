package array1;

import java.util.Scanner;

public class array3 {

	public static void main(String[] args) {
		int a, b, c;
		int sum;
		int[] arr = new int[10]; // 0~9 ���ڵ��� ���� Ƚ���� ������ �迭

		Scanner sc = new Scanner(System.in);
		a = sc.nextInt();
		b = sc.nextInt();
		c = sc.nextInt();
		
		sum = a*b*c; // �� ���� ��
		
		while(sum!=0) { // sum�� 0�϶����� �ݺ�
			arr[sum%10]++; // �����ڸ� ���ڿ� �ش��ϴ� �ε����� �迭 �� ����
			sum = sum / 10; // �����ڸ� ���ڸ� ����
		}
		
		for(int j=0; j<10; j++) {
			System.out.println(arr[j]); // ���ڵ��� ���� Ƚ���� ���
		}



	}

}
