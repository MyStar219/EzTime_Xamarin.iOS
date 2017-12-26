#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#define DEBUG 1
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <CloudKit/CloudKit.h>
#import <QuartzCore/QuartzCore.h>
#import <CoreLocation/CoreLocation.h>
#import <Intents/Intents.h>
#import <CoreGraphics/CoreGraphics.h>

@class __MonoMac_NSActionDispatcher;
@class __MonoMac_NSAsyncActionDispatcher;
@class UIKit_UIControlEventProxy;
@class AppDelegate;
@class EzTimeiOS_HoursTableSource;
@class ViewController;
@class HomeViewController;
@class HoursListViewController;
@class __UIGestureRecognizerToken;
@class __UIGestureRecognizerParameterlessToken;
@class __UIGestureRecognizerParametrizedToken;
@class __NSObject_Disposer;
@class CoreLocation_CLLocationManager__CLLocationManagerDelegate;
@class __UILongPressGestureRecognizer;
@class __UIPanGestureRecognizer;
@class __UIRotationGestureRecognizer;
@class __UITapGestureRecognizer;
@class __UIPinchGestureRecognizer;
@class __UISwipeGestureRecognizer;
@class __UIScreenEdgePanGestureRecognizer;
@class UIKit_UIScrollView__UIScrollViewDelegate;

@interface AppDelegate : NSObject<UIApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIWindow *) window;
	-(void) setWindow:(UIWindow *)p0;
	-(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1;
	-(void) applicationWillResignActive:(UIApplication *)p0;
	-(void) applicationDidEnterBackground:(UIApplication *)p0;
	-(void) applicationWillEnterForeground:(UIApplication *)p0;
	-(void) applicationDidBecomeActive:(UIApplication *)p0;
	-(void) applicationWillTerminate:(UIApplication *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface EzTimeiOS_HoursTableSource : NSObject<UIScrollViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * btnLogin;
	@property (nonatomic, assign) UIView * loginView;
	@property (nonatomic, assign) UITextField * txtFldPassword;
	@property (nonatomic, assign) UITextField * txtFldUserName;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnLogin;
	-(void) setBtnLogin:(UIButton *)p0;
	-(UIView *) loginView;
	-(void) setLoginView:(UIView *)p0;
	-(UITextField *) txtFldPassword;
	-(void) setTxtFldPassword:(UITextField *)p0;
	-(UITextField *) txtFldUserName;
	-(void) setTxtFldUserName:(UITextField *)p0;
	-(void) viewDidLoad;
	-(void) didReceiveMemoryWarning;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface HomeViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * btnBack;
	@property (nonatomic, assign) UIButton * btnMyHours;
	@property (nonatomic, assign) UIButton * btnRecord;
	@property (nonatomic, assign) UILabel * lblWelcome;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnBack;
	-(void) setBtnBack:(UIButton *)p0;
	-(UIButton *) btnMyHours;
	-(void) setBtnMyHours:(UIButton *)p0;
	-(UIButton *) btnRecord;
	-(void) setBtnRecord:(UIButton *)p0;
	-(UILabel *) lblWelcome;
	-(void) setLblWelcome:(UILabel *)p0;
	-(void) viewDidLoad;
	-(void) didReceiveMemoryWarning;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface HoursListViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * btnBack;
	@property (nonatomic, assign) UIButton * btnNextMonth;
	@property (nonatomic, assign) UIButton * btnPrevMonth;
	@property (nonatomic, assign) UIButton * btnSearch;
	@property (nonatomic, assign) UILabel * lblMonth;
	@property (nonatomic, assign) UILabel * lblTitle;
	@property (nonatomic, assign) UITableView * tblViewHours;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnBack;
	-(void) setBtnBack:(UIButton *)p0;
	-(UIButton *) btnNextMonth;
	-(void) setBtnNextMonth:(UIButton *)p0;
	-(UIButton *) btnPrevMonth;
	-(void) setBtnPrevMonth:(UIButton *)p0;
	-(UIButton *) btnSearch;
	-(void) setBtnSearch:(UIButton *)p0;
	-(UILabel *) lblMonth;
	-(void) setLblMonth:(UILabel *)p0;
	-(UILabel *) lblTitle;
	-(void) setLblTitle:(UILabel *)p0;
	-(UITableView *) tblViewHours;
	-(void) setTblViewHours:(UITableView *)p0;
	-(void) viewDidLoad;
	-(void) didReceiveMemoryWarning;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface __UIGestureRecognizerToken : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface __UIGestureRecognizerParameterlessToken : __UIGestureRecognizerToken {
}
	-(void) target;
@end

@interface __UIGestureRecognizerParametrizedToken : __UIGestureRecognizerToken {
}
	-(void) target:(UIGestureRecognizer *)p0;
@end


