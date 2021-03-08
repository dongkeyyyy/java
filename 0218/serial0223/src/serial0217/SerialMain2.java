package serial0217;

import java.util.Scanner;

public class SerialMain2 {
	public static final String ADMIN_ID = "admin";
	public static final String GUEST_ID = "guest";
	public static final String ADMIN_PW = "1234";
	public static final String GUEST_PW = "1111";
	public static final String ADMIN_MODE = "admin_mode";
	public static final String GUEST_MODE = "guest_mode";
	public static final String OTHER_MODE = "other_mode";

	public static final int MENU_TV_ON = 1;
	public static final int MENU_TV_OFF = 2;
	public static final int MENU_HEATER_ON = 3;
	public static final int MENU_CLEANER_ON = 4;
	public static final int MENU_GUEST_LOGOUT = 5;
	public static final int MENU_ADMIN_LOGOUT = 6;
	public static final int MENU_GUEST_EXIT = 6;
	public static final int MENU_ADMIN_EXIT = 7;
	public static final int MENU_EMARGENCY = 5;
	
	public static String login(Scanner s) {
		System.out.println("---------------");
		System.out.println("����ƮȨ ���� �α���");
		System.out.println("---------------");
		System.out.println("ID : ");
		String id = s.next();
		System.out.println("PW : ");
		String password = s.next();
		String mode;

		if (id.equals(ADMIN_ID) && password.equals(ADMIN_PW)) {
			mode = ADMIN_MODE;
		}

		else if (id.equals(GUEST_ID) && password.equals(GUEST_PW)) {
			mode = GUEST_MODE;
		}

		else {
			System.out.println("ID �Ǵ� ��й�ȣ�� �߸��Ǿ����ϴ�.");
			mode = OTHER_MODE;
		}

		return mode;

	}
	
	public static String logout(Scanner s) {
		System.out.println("�α׾ƿ� �ϼ̽��ϴ�.");
		System.out.println("ID : ");
		String id = s.next();
		System.out.println("PW : ");
		String password = s.next();
		String mode;

		if (id.equals(ADMIN_ID) && password.equals(ADMIN_PW)) {
			mode = ADMIN_MODE;
		}

		else if (id.equals(GUEST_ID) && password.equals(GUEST_PW)) {
			mode = GUEST_MODE;
		}

		else {
			System.out.println("ID �Ǵ� ��й�ȣ�� �߸��Ǿ����ϴ�.");
			mode = OTHER_MODE;
		}

		return mode;

	}

	public static int adminMenu(Scanner s) {
		System.out.println("----------------");
		System.out.println("����ƮȨ ���� ������");
		System.out.println("----------------");
		System.out.println("1. Tv �ѱ�");
		System.out.println("2. Tv ����");
		System.out.println("3. ���Ϸ� ����");
		System.out.println("4. ��Ź�� ����");
		System.out.println("5. ��� ����");
		System.out.println("6. �α׾ƿ�");
		System.out.println("----------------");
		System.out.print("�޴� ����");
		return s.nextInt();
	}

	public static int guestMenu(Scanner s) {
		System.out.println("----------------");
		System.out.println("����ƮȨ ���� �����");
		System.out.println("----------------");
		System.out.println("1. Tv �ѱ�");
		System.out.println("2. Tv ����");
		System.out.println("3. ���Ϸ� ����");
		System.out.println("4. ��Ź�� ����");
		System.out.println("5. ��� ����");
		System.out.println("6. �α׾ƿ�");		
		System.out.println("----------------");
		System.out.print("�޴� ����");
		return s.nextInt();
	}

	public static void adminWork(Scanner s) {
		switch (adminMenu(s)) {
		case 1:
			System.out.println("Tv �ѱ�");
			break;
		case 2:
			System.out.println("Tv ����");
			break;
		case 3:
			System.out.println("���Ϸ� ����");
			break;
		case 4:
			System.out.println("��Ź�� ����");
			break;
		case 5:
			System.out.println("��� ����");
			break;
		case MENU_ADMIN_LOGOUT:
			System.out.println("������ �α׾ƿ�");
		case 7:
			System.out.println("���α׷� ����");
			System.exit(0);
		}
	}

	public static void guestWork(Scanner s) {
		switch (guestMenu(s)) {
		case 1:
			break;
		case 2:
			break;
		case 3:
			break;
		case 4:
			break;
		case 5:
			System.out.println("���α׷� ����");
			s.close();
			System.exit(0);
		}
	}

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);

		while (true) {
			String mode = login(s);
			if (mode.equals(ADMIN_MODE)) {
				adminWork(s);
			} else if (mode.equals(GUEST_MODE)) {
				while (true) {
					guestWork(s);
				}

			} else {
				System.out.println("ID �Ǵ� ��й�ȣ�� �߸��Ǿ����ϴ�.");
				System.out.println("�ٽ� �Է��ϼ���.");
			}
		}
	}

}
