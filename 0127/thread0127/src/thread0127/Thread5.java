package thread0127;

public class Thread5 {
	public static void main(String[] args) {
		AutoThread th = new AutoThread();
		// ���󾲷���� ���ξ������� �������� �κ��̹Ƿ�
		// ���ξ����尡 ����Ǹ� �ڵ����� �����.
		th.setDaemon(true);
		th.start();
		for (int i = 0; i < 5; i++) {
			System.out.println("���ξ����� ����:" + i);
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("���ξ����� ����");
	}
}

class AutoThread extends Thread {
	public void save() {
		System.out.println("�۾� ���� ����");
	}

	@Override
	public void run() {
		while (true) {
			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			save();
		}
//		System.out.println("�۾� ������ ����");
	}

}