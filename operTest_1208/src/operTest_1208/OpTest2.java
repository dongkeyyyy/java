package operTest_1208;

public class OpTest2 {

	public static void main(String[] args) {
		int num1 = 10;
		int num2 = 0;
		
		// ++, -- ����������
		// 1����, 1����
		// ++�� �ڿ��پ������� ���Ŀ� �Ȱ��� ������ ����Ҷ� ���� ++�� �տ� �پ������� �ٷ� ����
		num2 = num1++;
		System.out.println("num2 : " + num2);
		
		num2 = ++num1;
		System.out.println("num2 : " + num2);
		
		// 12--;   ->    --num1�� �ٽ� ������ 1�� �����ϰ� �տ� ���� --�� 1�� �ٽ� ���� 10�� �ȴ� 
		// ó�� num1-- = 12�� ����ȴ� ������ num1�� ����ϸ� 11�� �ǰ� --num1�̱⶧���� 1�� �� ���� 10�̵�
		num2 = num1--;
		System.out.println("num2 : " + num2);
		
		num2 = --num1;
		System.out.println("num2 : " + num2);

	}

}
