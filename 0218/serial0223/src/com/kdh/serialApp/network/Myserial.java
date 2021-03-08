package com.kdh.serialApp.network;

import java.util.Scanner;

import com.kdh.serialApp.util.Menu;

public class Myserial {
	
	public String login(Scanner s) {
		Menu me = new Menu();
		System.out.println("-----------------");
		System.out.println("스마트홈 제어 로그인");
		System.out.println("-----------------");
		System.out.print("ID: ");
		String id = s.next();
		System.out.print("PW: ");
		String passwd = s.next();
		String mode;

		if (id.equals(me.ADMIN_ID) && passwd.equals(me.ADMIN_PW)) {
			mode = me.ADMIN_MODE;
		} else if (id.equals(me.GUEST_ID) && passwd.equals(me.GUEST_PW)) {
			mode = me.GUEST_MODE;
		} else {
			mode = me.OTHER_MODE;
		}
		return mode;
	}
}
