package thread0127;

public class Thread1 {

	public static void main(String[] args) throws 
		InterruptedException {
		MyThread t1 = new MyThread("T1");
		MyThread t2 = new MyThread("T2");
		t1.start(); // t1 ������ ��ü ���� ����
		t2.start();
		for(int i = 0;  i<10; i++) {
			System.out.println("main ������ ������");
			Thread.sleep(1000);
		}
		System.out.println("���� ������ ����");
	}

}

class MyThread extends Thread {
	String str;
		
	public MyThread(String str) {
		this.str = str;
	}

	// �����ε� : �ߺ� ����
	// �������̵� : �θ��� ��(�޼ҵ�)�� ������
	// work(�۾�) ������� �����ϴ� �κ�
	@Override 
	public void run() {
		for (int i= 0; i<10; i++) {
			System.out.println("main ������ ������");
			try {
				Thread.sleep(1000);  // ms(�и�������) ����	
			} 
			catch (InterruptedException e) {
				e.printStackTrace();
			}
			
		}
		System.out.println("�۾� ������ ����");
	}
	
	
}