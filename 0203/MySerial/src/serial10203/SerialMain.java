package serial10203;

public class SerialMain {
	public static void main(String[] args) {
		new MySerial().connect("COM5");
		System.out.println("��Ʈ ��� ����!");
	}
}
