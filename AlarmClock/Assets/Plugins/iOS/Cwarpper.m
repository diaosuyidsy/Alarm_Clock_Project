//
//  Cwarpper.m
//  libiOS
//
//  Created by 刁苏毅 on 12/2/16.
//  Copyright © 2016 刁苏毅. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Cwarpper.h" //My actual iOS library header

#ifdef __cplusplus
extern "C"
{
#endif
    bool askForUserPermit()
    {
        UNUserNotificationCenter *center = [UNUserNotificationCenter currentNotificationCenter];
        [center requestAuthorizationWithOptions:(UNAuthorizationOptionBadge | UNAuthorizationOptionSound | UNAuthorizationOptionAlert)
                              completionHandler:^(BOOL granted, NSError * _Nullable error) {
                                  if (!error) {
                                      NSLog(@"request authorization succeeded!");
//                                      [self showAlert];
                                  }
                              }];
        return true;
    }
    
    void registerForAlarm(int hour, int minute)
    {
        //Deliver the notification at 08:30 everyday
        NSDateComponents *dateComponents = [[NSDateComponents alloc] init];
        dateComponents.hour = hour;
        dateComponents.minute = minute;
        UNCalendarNotificationTrigger *trigger = [UNCalendarNotificationTrigger triggerWithDateMatchingComponents:dateComponents repeats:YES];
        
        UNMutableNotificationContent *content = [[UNMutableNotificationContent alloc] init];
        content.title = [NSString localizedUserNotificationStringForKey:@"Suyi said:" arguments:nil];
        content.body = [NSString localizedUserNotificationStringForKey:@"Hello Pence！Get up, let's play with Ken!"
                                                             arguments:nil];
        content.sound = [UNNotificationSound defaultSound];
        
//        // Deliver the notification in five seconds.
//        UNTimeIntervalNotificationTrigger *trigger = [UNTimeIntervalNotificationTrigger
//                                                      triggerWithTimeInterval:5.f repeats:NO];
        UNNotificationRequest *request = [UNNotificationRequest requestWithIdentifier:@"FiveSecond"
                                                                              content:content trigger:trigger];
        /// 3. schedule localNotification
        UNUserNotificationCenter *center = [UNUserNotificationCenter currentNotificationCenter];
        [center addNotificationRequest:request withCompletionHandler:^(NSError * _Nullable error) {
            if (!error) {
                NSLog(@"add NotificationRequest succeeded!");
            }
        }];
    }
#ifdef __cplusplus
}
#endif
