package thread0127;

import java.awt.Toolkit;

public class Thread3 {
	public static void main(String[] args) {
		Runnable task = new BeepTask(task);
		Thread th = new Thread(task);
		th.start();
		for (int i = 0; i < 5; i++) {
			toolkit.beep();
			System.out.println("작업쓰레드 : " + i);
			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("메인쓰레드 종료");

	}
}

// Runnable 인터페이스를 사용
// Interface는 반드시 오버라이딩
class BeepTask implements Runnable {

	@Override
	public void run() {
		Toolkit toolkit = Toolkit.getDefaultToolkit();
		for (int i = 0; i < 5; i++) {
			toolkit.beep();
			System.out.println("작업쓰레드 : " + i);
			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("작업쓰레드 종료");
	}

}