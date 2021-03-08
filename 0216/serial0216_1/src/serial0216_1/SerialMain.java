package serial0216_1;

import java.util.Scanner;
import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SerialMain {

	static final int TV_ON = 1;
	static final int TV_OFF = 2;
	static final int HOTTER_ON = 3;
	static final int CLEANER_ON = 4;
	static final int PROGRAM_EXIT = 5;

	static final int CMD_TV_ON = '1';
	static final int CMD_TV_OFF = '0';
	static final int CMD_HOTTER_ON = '2';
	static final int CMD_CLEANER_ON = '3';

	public static int getMenu(Scanner s) {

		System.out.println("-------------------------");
		System.out.println("����Ʈ Ȩ ���� v1.0");
		System.out.println("-------------------------");
		System.out.println("1. Tv �ѱ�");
		System.out.println("2. Tv ����");
		System.out.println("3. ���Ϸ� ����");
		System.out.println("4. ��Ź�� ����");
		System.out.println("5. ���α׷� ����");
		System.out.println("-------------------------");
		System.out.println("�޴� ���� : ");

//		int menu = s.nextInt();	 return menu;   �ΰ����� ��ġ�� return s.nextInt();
		return s.nextInt();

	}

	public static SerialPort initSerial() {
		// �Ʒ� for���� ���̺귯�� ����
		String[] portNames = SerialPortList.getPortNames();
		for (int i = 0; i < portNames.length; i++) {
			System.out.println(portNames[i]);
		}
		SerialPort serialPort = new SerialPort(portNames[0]); // �ø�����Ʈ ��ü ���� => ��� ���� ��Ʈ Ȯ��

		// �Ʒ� try catch ���� �ø�����Ʈ ����+�ʱ�ȭ
		try {
			serialPort.openPort();
			serialPort.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1,
					SerialPort.PARITY_NONE);
		} catch (SerialPortException e) {
			e.printStackTrace();
		}

		return serialPort;

//				ReadThread rt = new ReadThread(serialPort);
//				rt.start();
//				WriteThread wt = new WriteThread(serialPort);
//				wt.start();
	}

	public static void main(String[] args) {
		initSerial();
		Scanner s = new Scanner(System.in);
		SerialPort serial = initSerial();

		while (true) {
			switch (getMenu(s)) {
			case TV_ON:
				System.out.println("TV ON");
				try {
					serial.writeInt(CMD_TV_ON);
				} catch (SerialPortException e4) {
					// TODO Auto-generated catch block
					e4.printStackTrace();
				}
				break;

			case TV_OFF:
				System.out.println("TV OFF");
				try {
					serial.writeInt(CMD_TV_OFF);
				} catch (SerialPortException e3) {
					// TODO Auto-generated catch block
					e3.printStackTrace();
				}
				break;

			case HOTTER_ON:
				System.out.println("���Ϸ� ����");
				try {
					serial.writeInt(CMD_HOTTER_ON);
				} catch (SerialPortException e2) {
					// TODO Auto-generated catch block
					e2.printStackTrace();
				}
				break;

			case CLEANER_ON:
				System.out.println("��Ź�� ����");
				try {
					serial.writeInt(CMD_CLEANER_ON);
				} catch (SerialPortException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
				break;

			case PROGRAM_EXIT:
				System.out.println("���α׷� ����");
				try {
					serial.writeInt(4);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}

				s.close();
				System.exit(0);
				break;

			}
		}

	}

}
