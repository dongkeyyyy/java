package method1230;

public class Method2 {

	public static void func() {
		System.out.println("func() ���");
		// �޽�� ������ �ٸ� �޽�带 ȣ�� ������
		func1();
	}

	public static void func1() {
		System.out.println("func1() ���");
		func2();

	}

	public static void func2() {
		System.out.println("func2() ���");

	}

	public static void main(String[] args) {
		func();
		System.out.println("��� �޽�� ����");

	}
}