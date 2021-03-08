package com.kdh.serialApp;

import java.util.Scanner;

import com.kdh.serialApp.handler.SerialCtrl;
import com.kdh.serialApp.network.Myserial;
import com.kdh.serialApp.util.Menu;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SerialMain {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		SerialCtrl sc = new SerialCtrl();
		Myserial ms = new Myserial();
		Menu me = new Menu();
		SerialPort serial = sc.initSerial();

		while (true) {
			String mode = ms.login(s);
			if (mode.equals(me.ADMIN_MODE)) {
				while (true) {
					if (me.adminWork(s, serial) == false) {
						break;
					}
				}
			} else if (mode.equals(me.GUEST_MODE)) {
				while (true) {
					if (!me.guestWork(s, serial)) {
						break;
					}
				}
			} else {
				System.out.println("ID 또는 비번이 잘못되었습니다.");
				System.out.println("다시 입력하세요.");
			}
		}
	}

}
