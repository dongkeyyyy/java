package com.kdh.serialApp.util;

import java.util.Scanner;

import com.kdh.serialApp.handler.SerialCtrl;

import jssc.SerialPort;
import jssc.SerialPortException;

public class Menu {

	public static final int MENU_TV_ON = 1;
	public static final int MENU_TV_OFF = 2;
	public static final int MENU_HEATER_ON = 3;
	public static final int MENU_CLEANER_ON = 4;
	public static final int MENU_GUEST_LOGOUT = 5;
	public static final int MENU_ADMIN_LOGOUT = 7;
	public static final int MENU_GUEST_EXIT = 6;
	public static final int MENU_ADMIN_EXIT = 8;
	public static final int MENU_EMARGENCY = 5;
	public static final int MENU_ADMIN_RECONN = 6;

	static final int CMD_TV_ON = '1';
	static final int CMD_TV_OFF = '0';
	static final int CMD_HEATTER_ON = '2';
	static final int CMD_CLEANER_ON = '3';

	public static final String ADMIN_ID = "admin";
	public static final String GUEST_ID = "guest";
	public static final String ADMIN_PW = "1234";
	public static final String GUEST_PW = "1111";
	public static final String ADMIN_MODE = "admin_mode";
	public static final String GUEST_MODE = "guest_mode";
	public static final String OTHER_MODE = "other_mode";

	public static int adminMenu(Scanner s) {
		System.out.println("------------------");
		System.out.println("����ƮȨ ���� ������");
		System.out.println("------------------");
		System.out.println("1.TV �ѱ�");
		System.out.println("2.TV ����");
		System.out.println("3.���Ϸ� ����");
		System.out.println("4.��Ź�� ����");
		System.out.println("5.��� ����");
		System.out.println("6.��� �翬��");
		System.out.println("7.�α׾ƿ�");
		System.out.println("8.����");
		System.out.println("------------------");
		System.out.print("�޴� ����: ");
		return s.nextInt();
	}

	public static int guestMenu(Scanner s) {
		System.out.println("------------------");
		System.out.println("����ƮȨ ���� �����");
		System.out.println("------------------");
		System.out.println("1.TV �ѱ�");
		System.out.println("2.TV ����");
		System.out.println("3.���Ϸ� ����");
		System.out.println("4.��Ź�� ����");
		System.out.println("5.�α� �ƿ�");
		System.out.println("6.����");
		System.out.println("------------------");
		System.out.print("�޴� ����: ");
		return s.nextInt();
	}

	public static boolean adminWork(Scanner s, SerialPort serial) {
		switch (adminMenu(s)) {
		case MENU_TV_ON:
			System.out.println("TV �ѱ�");
			try {
				serial.writeInt(CMD_TV_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_TV_OFF:
			System.out.println("TV ����");
			try {
				serial.writeInt(CMD_TV_OFF);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_HEATER_ON:
			System.out.println("���Ϸ� ����");
			try {
				serial.writeInt(CMD_HEATTER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_CLEANER_ON:
			System.out.println("��Ź�� ����");
			try {
				serial.writeInt(CMD_CLEANER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_EMARGENCY:
			System.out.println("��� ����");
			try {
				serial.closePort();
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;

		case MENU_ADMIN_LOGOUT:
			System.out.println("������ �α� �ƿ�");
			return false;

		case MENU_ADMIN_EXIT:
			System.out.println("���α׷� ����");
			s.close();
			System.exit(0);
		}
		return true;
	}

	public static boolean guestWork(Scanner s, SerialPort serial) {
		switch (guestMenu(s)) {
		case MENU_TV_ON:
			System.out.println("TV �ѱ�");
			try {
				serial.writeInt(CMD_TV_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_TV_OFF:
			System.out.println("TV ����");
			try {
				serial.writeInt(CMD_TV_OFF);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_HEATER_ON:
			System.out.println("���Ϸ� ����");
			try {
				serial.writeInt(CMD_HEATTER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_CLEANER_ON:
			System.out.println("��Ź�� ����");
			try {
				serial.writeInt(CMD_CLEANER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;

		case MENU_GUEST_LOGOUT:
			System.out.println("�Խ�Ʈ �α� �ƿ�");
			return false;
		case MENU_GUEST_EXIT:
			System.out.println("���α׷� ����");
			s.close();
			System.exit(0);
		}
		return true;
	}

}
