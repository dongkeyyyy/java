package operTest_1208;

public class OpTest5 {

	public static void main(String[] args) {
		// 3�� ������ 10 + 2 ���� 10�� 2�� ���̶�� �θ���. 10+2 = ���� 2���̹Ƿ� ���� �����ڶ�� �θ�  ��Ʈ4= ���� ������
		// ������ ��ȣ�� ������ ������ �޽���̴�.
		// �޽�� �ȿ��� ����� ������ �ʱⰪ�� 
		// ������ �����Ⱚ�� ��.
		int num1 = 10;
		int num2 = 15;
		String str = "";
		str = (++num1 >= num2) ? "num1�� ũ��" : "num2�� ũ��";  // ++num1 = 10+1�̹Ƿ� 11.  11>=15 = false .   true�� "num1�� ũ��"�� ������ �ϰ� false�� "num2�� ũ��"�� ������ ��
		System.out.println(str);

	}

}
