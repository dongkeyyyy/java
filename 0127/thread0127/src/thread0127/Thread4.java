package thread0127;

public class Thread4 {
	public static void main(String[] args) {
		Thread th = new MovieThread();
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
		th.interrupt();
	}
}

class MovieThread extends Thread {
	@Override
	public void run() {
		while (true) {
			System.err.println("������ ���");
//			if (isInterrupted()) {
//				System.out.println("���ͷ�Ʈ ��ȣ ����");
//				break;
//			}
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				System.out.println("���ͷ�Ʈ ��ȣ����2");
//				e.printStackTrace();  //����� �뵵
				break;
			}
		}
//		System.out.println("�۾� ������ ����");
	}

}