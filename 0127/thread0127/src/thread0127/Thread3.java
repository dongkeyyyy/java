package thread0127;

import java.awt.Toolkit;

public class Thread3 {
	public static void main(String[] args) {
		Runnable task = new BeepTask(task);
		Thread th = new Thread(task);
		th.start();
		for (int i = 0; i < 5; i++) {
			toolkit.beep();
			System.out.println("�۾������� : " + i);
			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("���ξ����� ����");

	}
}

// Runnable �������̽��� ���
// Interface�� �ݵ�� �������̵�
class BeepTask implements Runnable {

	@Override
	public void run() {
		Toolkit toolkit = Toolkit.getDefaultToolkit();
		for (int i = 0; i < 5; i++) {
			toolkit.beep();
			System.out.println("�۾������� : " + i);
			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("�۾������� ����");
	}

}