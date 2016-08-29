using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace JWPlayerIOSXamarin
{
	// @interface JWAdConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface JWAdConfig
	{
		// @property (retain, nonatomic) NSString * adMessage;
		[Export ("adMessage", ArgumentSemantic.Retain)]
		string AdMessage { get; set; }

		// @property (retain, nonatomic) NSString * skipMessage;
		[Export ("skipMessage", ArgumentSemantic.Retain)]
		string SkipMessage { get; set; }

		// @property (retain, nonatomic) NSString * skipText;
		[Export ("skipText", ArgumentSemantic.Retain)]
		string SkipText { get; set; }

		// @property (nonatomic) int skipOffset;
		[Export ("skipOffset")]
		int SkipOffset { get; set; }

		// @property (nonatomic) JWAdClient adClient;
		[Export ("adClient", ArgumentSemantic.Assign)]
		JWAdClient AdClient { get; set; }
	}

	// @interface JWAdBreak : NSObject
	[BaseType (typeof(NSObject))]
	interface JWAdBreak
	{
		// @property (retain, nonatomic) NSString * offset;
		[Export ("offset", ArgumentSemantic.Retain)]
		string Offset { get; set; }

		// @property (retain, nonatomic) NSString * tag;
		[Export ("tag", ArgumentSemantic.Retain)]
		string Tag { get; set; }

		// @property (retain, nonatomic) NSArray * tags;
		[Export ("tags", ArgumentSemantic.Retain)]
		//// [Verify (StronglyTypedNSArray)]
		NSObject[] Tags { get; set; }

		// @property (nonatomic) BOOL nonLinear;
		[Export ("nonLinear")]
		bool NonLinear { get; set; }

		// +(instancetype)adBreakWithTag:(NSString *)tag offset:(NSString *)offset nonLinear:(BOOL)nonLinear;
		[Static]
		[Export ("adBreakWithTag:offset:nonLinear:")]
		JWAdBreak AdBreakWithTag (string tag, string offset, bool nonLinear);

		// +(instancetype)adBreakWithTags:(NSArray *)tags offset:(NSString *)offset nonLinear:(BOOL)nonLinear;
		[Static]
		[Export ("adBreakWithTags:offset:nonLinear:")]
		//// [Verify (StronglyTypedNSArray)]
		JWAdBreak AdBreakWithTags (NSObject[] tags, string offset, bool nonLinear);

		// +(instancetype)adBreakWithTag:(NSString *)tag offset:(NSString *)offset;
		[Static]
		[Export ("adBreakWithTag:offset:")]
		JWAdBreak AdBreakWithTag (string tag, string offset);

		// +(instancetype)adBreakWithTags:(NSArray *)tags offset:(NSString *)offset;
		[Static]
		[Export ("adBreakWithTags:offset:")]
		//// [Verify (StronglyTypedNSArray)]
		JWAdBreak AdBreakWithTags (NSObject[] tags, string offset);

		// -(instancetype)initWithTags:(NSArray *)tags offset:(NSString *)offset;
		[Export ("initWithTags:offset:")]
		//// [Verify (StronglyTypedNSArray)]
		IntPtr Constructor (NSObject[] tags, string offset);
	}

	// @interface JWTrack : NSObject
	[BaseType (typeof(NSObject))]
	interface JWTrack
	{
		// @property (retain, nonatomic) NSString * file;
		[Export ("file", ArgumentSemantic.Retain)]
		string File { get; set; }

		// @property (retain, nonatomic) NSString * label;
		[Export ("label", ArgumentSemantic.Retain)]
		string Label { get; set; }

		// @property (retain, nonatomic) NSString * kind;
		[Export ("kind", ArgumentSemantic.Retain)]
		string Kind { get; set; }

		// @property (nonatomic) BOOL defaultValue;
		[Export ("defaultValue")]
		bool DefaultValue { get; set; }

		// +(instancetype)trackWithFile:(NSString *)file label:(NSString *)label;
		[Static]
		[Export ("trackWithFile:label:")]
		JWTrack TrackWithFile (string file, string label);

		// +(instancetype)trackWithFile:(NSString *)file label:(NSString *)label isDefault:(BOOL)def;
		[Static]
		[Export ("trackWithFile:label:isDefault:")]
		JWTrack TrackWithFile (string file, string label, bool def);

		// -(instancetype)initWithFile:(NSString *)file label:(NSString *)label;
		[Export ("initWithFile:label:")]
		IntPtr Constructor (string file, string label);

		// -(instancetype)initWithFile:(NSString *)file label:(NSString *)label isDefault:(BOOL)def;
		[Export ("initWithFile:label:isDefault:")]
		IntPtr Constructor (string file, string label, bool def);
	}

	// @interface JWSource : NSObject
	[BaseType (typeof(NSObject))]
	interface JWSource
	{
		// @property (retain, nonatomic) NSString * file;
		[Export ("file", ArgumentSemantic.Retain)]
		string File { get; set; }

		// @property (retain, nonatomic) NSString * label;
		[Export ("label", ArgumentSemantic.Retain)]
		string Label { get; set; }

		// @property (nonatomic) BOOL defaultQuality;
		[Export ("defaultQuality")]
		bool DefaultQuality { get; set; }

		// +(instancetype)sourceWithFile:(NSString *)file label:(NSString *)label;
		[Static]
		[Export ("sourceWithFile:label:")]
		JWSource SourceWithFile (string file, string label);

		// +(instancetype)sourceWithFile:(NSString *)file label:(NSString *)label isDefault:(BOOL)defaultQuality;
		[Static]
		[Export ("sourceWithFile:label:isDefault:")]
		JWSource SourceWithFile (string file, string label, bool defaultQuality);

		// -(instancetype)initWithFile:(NSString *)file label:(NSString *)label isDefault:(BOOL)defaultQuality;
		[Export ("initWithFile:label:isDefault:")]
		IntPtr Constructor (string file, string label, bool defaultQuality);
	}

	// @interface JWPlaylistItem : NSObject
	[BaseType (typeof(NSObject))]
	interface JWPlaylistItem
	{
		// @property (retain, nonatomic) NSArray * sources;
		[Export ("sources", ArgumentSemantic.Retain)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] Sources { get; set; }

		// @property (retain, nonatomic) NSString * file;
		[Export ("file", ArgumentSemantic.Retain)]
		string File { get; set; }

		// @property (retain, nonatomic) NSString * image;
		[Export ("image", ArgumentSemantic.Retain)]
		string Image { get; set; }

		// @property (retain, nonatomic) NSString * title;
		[Export ("title", ArgumentSemantic.Retain)]
		string Title { get; set; }

		// @property (retain, nonatomic) NSArray * adSchedule;
		[Export ("adSchedule", ArgumentSemantic.Retain)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] AdSchedule { get; set; }

		// @property (retain, nonatomic) NSArray * tracks;
		[Export ("tracks", ArgumentSemantic.Retain)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] Tracks { get; set; }

		// @property (retain, nonatomic) NSString * desc;
		[Export ("desc", ArgumentSemantic.Retain)]
		string Desc { get; set; }

		// +(instancetype)playlistItemWithConfig:(JWConfig *)config;
		[Static]
		[Export ("playlistItemWithConfig:")]
		JWPlaylistItem PlaylistItemWithConfig (JWConfig config);
	}

	// @interface JWCaptionStyling : NSObject
	[BaseType (typeof(NSObject))]
	interface JWCaptionStyling
	{
		// @property (retain, nonatomic) UIColor * fontColor;
		[Export ("fontColor", ArgumentSemantic.Retain)]
		UIColor FontColor { get; set; }

		// @property (retain, nonatomic) UIColor * windowColor;
		[Export ("windowColor", ArgumentSemantic.Retain)]
		UIColor WindowColor { get; set; }

		// @property (retain, nonatomic) UIColor * backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Retain)]
		UIColor BackgroundColor { get; set; }

		// @property (retain, nonatomic) UIFont * font;
		[Export ("font", ArgumentSemantic.Retain)]
		UIFont Font { get; set; }

		// @property (nonatomic) JWEdgeStyle edgeStyle;
		[Export ("edgeStyle", ArgumentSemantic.Assign)]
		JWEdgeStyle EdgeStyle { get; set; }
	}

	// @interface JWConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface JWConfig
	{
		// @property (retain, nonatomic) JWCaptionStyling * captionStyling;
		[Export ("captionStyling", ArgumentSemantic.Retain)]
		JWCaptionStyling CaptionStyling { get; set; }

		// @property (retain, nonatomic) NSString * file;
		[Export ("file", ArgumentSemantic.Retain)]
		string File { get; set; }

		// @property (retain, nonatomic) NSArray * sources;
		[Export ("sources", ArgumentSemantic.Retain)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] Sources { get; set; }

		// @property (retain, nonatomic) NSArray * playlist;
		[Export ("playlist", ArgumentSemantic.Retain)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] Playlist { get; set; }

		// @property (retain, nonatomic) NSString * title;
		[Export ("title", ArgumentSemantic.Retain)]
		string Title { get; set; }

		// @property (retain, nonatomic) NSString * image;
		[Export ("image", ArgumentSemantic.Retain)]
		string Image { get; set; }

		// @property (retain, nonatomic) UIImage * offlinePoster;
		[Export ("offlinePoster", ArgumentSemantic.Retain)]
		UIImage OfflinePoster { get; set; }

		// @property (retain, nonatomic) NSString * offlineMessage;
		[Export ("offlineMessage", ArgumentSemantic.Retain)]
		string OfflineMessage { get; set; }

		// @property (nonatomic) CGSize size;
		[Export ("size", ArgumentSemantic.Assign)]
		CGSize Size { get; set; }

		// @property (retain, nonatomic) JWAdConfig * adConfig;
		[Export ("adConfig", ArgumentSemantic.Retain)]
		JWAdConfig AdConfig { get; set; }

		// @property (nonatomic) BOOL controls;
		[Export ("controls")]
		bool Controls { get; set; }

		// @property (nonatomic) BOOL repeat;
		[Export ("repeat")]
		bool Repeat { get; set; }

		// @property (nonatomic) BOOL autostart;
		[Export ("autostart")]
		bool Autostart { get; set; }

		// @property (retain, nonatomic) NSArray * adSchedule;
		[Export ("adSchedule", ArgumentSemantic.Retain)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] AdSchedule { get; set; }

		// @property (retain, nonatomic) NSString * adVmap;
		[Export ("adVmap", ArgumentSemantic.Retain)]
		string AdVmap { get; set; }

		// @property (nonatomic) JWPremiumSkin premiumSkin;
		[Export ("premiumSkin", ArgumentSemantic.Assign)]
		JWPremiumSkin PremiumSkin { get; set; }

		// @property (retain, nonatomic) NSString * cssSkin;
		[Export ("cssSkin", ArgumentSemantic.Retain)]
		string CssSkin { get; set; }

		// @property (retain, nonatomic) NSArray * tracks;
		[Export ("tracks", ArgumentSemantic.Retain)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] Tracks { get; set; }

		// @property (nonatomic) JWStretching stretch;
		[Export ("stretch", ArgumentSemantic.Assign)]
		JWStretching Stretch { get; set; }

		// +(instancetype)configWithContentURL:(NSString *)contentUrl;
		[Static]
		[Export ("configWithContentURL:")]
		JWConfig ConfigWithContentURL (string contentUrl);

		// -(instancetype)initWithContentUrl:(NSString *)contentUrl;
		[Export ("initWithContentUrl:")]
		IntPtr Constructor (string contentUrl);
	}

	// @protocol JWPlayerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface JWPlayerDelegate
	{
		// @optional -(void)onAll;
		[Export ("onAll")]
		void OnAll ();

		// @optional -(void)onPlayAttempt;
		[Export ("onPlayAttempt")]
		void OnPlayAttempt ();

		// @optional -(void)onBeforePlay;
		[Export ("onBeforePlay")]
		void OnBeforePlay ();

		// @optional -(void)onFirstFrame:(NSInteger)loadTime;
		[Export ("onFirstFrame:")]
		void OnFirstFrame (nint loadTime);

		// @optional -(void)onPlay;
		[Export ("onPlay")]
		void OnPlay ();

		// @optional -(void)onPause;
		[Export ("onPause")]
		void OnPause ();

		// @optional -(void)onIdle;
		[Export ("onIdle")]
		void OnIdle ();

		// @optional -(void)onReady;
		[Export ("onReady")]
		void OnReady ();

		// @optional -(void)onBeforeComplete;
		[Export ("onBeforeComplete")]
		void OnBeforeComplete ();

		// @optional -(void)onComplete;
		[Export ("onComplete")]
		void OnComplete ();

		// @optional -(void)onBuffer;
		[Export ("onBuffer")]
		void OnBuffer ();

		// @optional -(void)onBufferChange:(double)buffer;
		[Export ("onBufferChange:")]
		void OnBufferChange (double buffer);

		// @optional -(void)onTime:(double)position ofDuration:(double)duration;
		[Export ("onTime:ofDuration:")]
		void OnTime (double position, double duration);

		// @optional -(void)onSeek:(double)offset fromPosition:(double)position;
		[Export ("onSeek:fromPosition:")]
		void OnSeek (double offset, double position);

		// @optional -(void)onSeeked;
		[Export ("onSeeked")]
		void OnSeeked ();

		// @optional -(void)onMeta:(NSDictionary *)metaData;
		[Export ("onMeta:")]
		void OnMeta (NSDictionary metaData);

		// @optional -(void)onCaptionsList:(NSArray *)tracks with:(NSInteger)selectedTrack;
		[Export ("onCaptionsList:with:")]
		// [Verify (StronglyTypedNSArray)]
		void OnCaptionsList (NSObject[] tracks, nint selectedTrack);

		// @optional -(void)onCaptionsChanged:(NSInteger)selectedTrack;
		[Export ("onCaptionsChanged:")]
		void OnCaptionsChanged (nint selectedTrack);

		// @optional -(void)onCaptionsChange:(NSInteger)selectedTrack __attribute__((deprecated("Use onCaptionsChanged: instead")));
		[Export ("onCaptionsChange:")]
		void OnCaptionsChange (nint selectedTrack);

		// @optional -(void)onLevels:(NSArray *)levels;
		[Export ("onLevels:")]
		// [Verify (StronglyTypedNSArray)]
		void OnLevels (NSObject[] levels);

		// @optional -(void)onQualityLevels:(NSArray *)levels __attribute__((deprecated("Use onLevels: instead")));
		[Export ("onQualityLevels:")]
		// [Verify (StronglyTypedNSArray)]
		void OnQualityLevels (NSObject[] levels);

		// @optional -(void)onLevelsChanged:(NSInteger)currentLevel;
		[Export ("onLevelsChanged:")]
		void OnLevelsChanged (nint currentLevel);

		// @optional -(void)onQualityChange:(NSInteger)currentQuality __attribute__((deprecated("Use onLevelsChanged: instead")));
		[Export ("onQualityChange:")]
		void OnQualityChange (nint currentQuality);

		// @optional -(void)onVisualQuality:(NSString *)mode reason:(NSString *)reason label:(NSString *)label;
		[Export ("onVisualQuality:reason:label:")]
		void OnVisualQuality (string mode, string reason, string label);

		// @optional -(void)onAudioTracks:(NSArray *)audioTracks;
		[Export ("onAudioTracks:")]
		// [Verify (StronglyTypedNSArray)]
		void OnAudioTracks (NSObject[] audioTracks);

		// @optional -(void)onAudioTrackChanged:(NSInteger)currentAudioTrack;
		[Export ("onAudioTrackChanged:")]
		void OnAudioTrackChanged (nint currentAudioTrack);

		// @optional -(void)onPlaylist:(NSArray *)playlist;
		[Export ("onPlaylist:")]
		// [Verify (StronglyTypedNSArray)]
		void OnPlaylist (NSObject[] playlist);

		// @optional -(void)onPlaylistItem:(NSInteger)index;
		[Export ("onPlaylistItem:")]
		void OnPlaylistItem (nint index);

		// @optional -(void)onPlaylistComplete;
		[Export ("onPlaylistComplete")]
		void OnPlaylistComplete ();

		// @optional -(void)onFullscreen:(BOOL)status;
		[Export ("onFullscreen:")]
		void OnFullscreen (bool status);

		// @optional -(void)onPictureInPicture:(BOOL)status;
		[Export ("onPictureInPicture:")]
		void OnPictureInPicture (bool status);

		// @optional -(void)onControls:(BOOL)status;
		[Export ("onControls:")]
		void OnControls (bool status);

		// @optional -(void)onDisplayClick;
		[Export ("onDisplayClick")]
		void OnDisplayClick ();

		// @optional -(void)onAdRequest:(NSString *)tag forPosition:(NSString *)adPosition;
		[Export ("onAdRequest:forPosition:")]
		void OnAdRequest (string tag, string adPosition);

		// @optional -(void)onAdSkipped:(NSString *)tag;
		[Export ("onAdSkipped:")]
		void OnAdSkipped (string tag);

		// @optional -(void)onAdComplete:(NSString *)tag;
		[Export ("onAdComplete:")]
		void OnAdComplete (string tag);

		// @optional -(void)onAdClick:(NSString *)tag;
		[Export ("onAdClick:")]
		void OnAdClick (string tag);

		// @optional -(void)onAdImpression:(NSString *)tag;
		[Export ("onAdImpression:")]
		void OnAdImpression (string tag);

		// @optional -(void)onAdPlay:(NSString *)tag;
		[Export ("onAdPlay:")]
		void OnAdPlay (string tag);

		// @optional -(void)onAdPause:(NSString *)tag;
		[Export ("onAdPause:")]
		void OnAdPause (string tag);

		// @optional -(void)onAdTime:(double)position ofDuration:(double)duration tag:(NSString *)tag index:(NSInteger)sequence;
		[Export ("onAdTime:ofDuration:tag:index:")]
		void OnAdTime (double position, double duration, string tag, nint sequence);

		// @optional -(void)onAdError:(NSError *)error;
		[Export ("onAdError:")]
		void OnAdError (NSError error);

		// @optional -(void)onError:(NSError *)error;
		[Export ("onError:")]
		void OnError (NSError error);

		// @optional -(void)onSetupError:(NSError *)error;
		[Export ("onSetupError:")]
		void OnSetupError (NSError error);
	}

	// @protocol JWCastingDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface JWCastingDelegate
	{
		// @required -(void)onCastingDevicesAvailable:(NSArray<JWCastingDevice *> *)devices;
		[Abstract]
		[Export ("onCastingDevicesAvailable:")]
		void OnCastingDevicesAvailable (JWCastingDevice[] devices);

		// @optional -(void)onConnectedToCastingDevice:(JWCastingDevice *)device;
		[Export ("onConnectedToCastingDevice:")]
		void OnConnectedToCastingDevice (JWCastingDevice device);

		// @optional -(void)onDisconnectedFromCastingDevice:(NSError *)error;
		[Export ("onDisconnectedFromCastingDevice:")]
		void OnDisconnectedFromCastingDevice (NSError error);

		// @optional -(void)onConnectionTemporarilySuspended;
		[Export ("onConnectionTemporarilySuspended")]
		void OnConnectionTemporarilySuspended ();

		// @optional -(void)onConnectionRecovered;
		[Export ("onConnectionRecovered")]
		void OnConnectionRecovered ();

		// @optional -(void)onConnectionFailed:(NSError *)error;
		[Export ("onConnectionFailed:")]
		void OnConnectionFailed (NSError error);

		// @optional -(void)onCasting;
		[Export ("onCasting")]
		void OnCasting ();

		// @optional -(void)onCastingFailed:(NSError *)error;
		[Export ("onCastingFailed:")]
		void OnCastingFailed (NSError error);

		// @optional -(void)onCastingEnded:(NSError *)error;
		[Export ("onCastingEnded:")]
		void OnCastingEnded (NSError error);
	}

	// @interface JWCastingDevice : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface JWCastingDevice
	{
		// @property (readonly, nonatomic) JWCastingService castingService;
		[Export ("castingService")]
		JWCastingService CastingService { get; }

		// @property (readonly, nonatomic) NSString * name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic) NSString * identifier;
		[Export ("identifier")]
		string Identifier { get; }
	}

	// @interface JWCastController : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface JWCastController
	{
		// @property (nonatomic, weak) JWPlayerController * player;
		[Export ("player", ArgumentSemantic.Weak)]
		JWPlayerController Player { get; set; }

		// @property (nonatomic) NSString * chromeCastReceiverAppID;
		[Export ("chromeCastReceiverAppID")]
		string ChromeCastReceiverAppID { get; set; }

		[Wrap ("WeakDelegate")]
		JWCastingDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<JWCastingDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic) JWCastingDevice * connectedDevice;
		[Export ("connectedDevice")]
		JWCastingDevice ConnectedDevice { get; }

		// @property (readonly, nonatomic) NSArray * availableDevices;
		[Export ("availableDevices")]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] AvailableDevices { get; }

		// -(instancetype)initWithPlayer:(JWPlayerController *)player;
		[Export ("initWithPlayer:")]
		IntPtr Constructor (JWPlayerController player);

		// -(void)scanForDevices;
		[Export ("scanForDevices")]
		void ScanForDevices ();

		// -(void)connectToDevice:(JWCastingDevice *)device;
		[Export ("connectToDevice:")]
		void ConnectToDevice (JWCastingDevice device);

		// -(void)disconnect;
		[Export ("disconnect")]
		void Disconnect ();

		// -(void)cast;
		[Export ("cast")]
		void Cast ();

		// -(void)stopCasting;
		[Export ("stopCasting")]
		void StopCasting ();
	}

	// @protocol JWDrmDataSource <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface JWDrmDataSource
	{
		// @required -(void)fetchContentIdentifierForRequest:(NSURL *)loadingRequestURL forEncryption:(JWEncryption)encryption withCompletion:(void (^)(NSData *))completion;
		[Abstract]
		[Export ("fetchContentIdentifierForRequest:forEncryption:withCompletion:")]
		void FetchContentIdentifierForRequest (NSUrl loadingRequestURL, JWEncryption encryption, Action<NSData> completion);

		// @required -(void)fetchAppIdentifierForRequest:(NSURL *)loadingRequestURL forEncryption:(JWEncryption)encryption withCompletion:(void (^)(NSData *))completion;
		[Abstract]
		[Export ("fetchAppIdentifierForRequest:forEncryption:withCompletion:")]
		void FetchAppIdentifierForRequest (NSUrl loadingRequestURL, JWEncryption encryption, Action<NSData> completion);

		// @required -(void)fetchContentKeyWithRequest:(NSData *)requestBytes forEncryption:(JWEncryption)encryption withCompletion:(void (^)(NSData *, NSDate *, NSString *))completion;
		[Abstract]
		[Export ("fetchContentKeyWithRequest:forEncryption:withCompletion:")]
		void FetchContentKeyWithRequest (NSData requestBytes, JWEncryption encryption, Action<NSData, NSDate, NSString> completion);
	}

	// @interface JWPlayerController : NSObject
	[BaseType (typeof(NSObject))]
	interface JWPlayerController
	{
		// @property (readonly, retain, nonatomic) UIView * view;
		[Export ("view", ArgumentSemantic.Retain)]
		UIView View { get; }

		[Wrap ("WeakDelegate")]
		JWPlayerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<JWPlayerDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<JWDrmDataSource> drmDataSource;
		[Export ("drmDataSource", ArgumentSemantic.Weak)]
		JWDrmDataSource DrmDataSource { get; set; }

		// @property (readonly, retain, nonatomic) NSString * googleIMAVersion;
		[Export ("googleIMAVersion", ArgumentSemantic.Retain)]
		string GoogleIMAVersion { get; }

		// @property (readonly, retain, nonatomic) NSString * googleChromeCastVersion;
		[Export ("googleChromeCastVersion", ArgumentSemantic.Retain)]
		string GoogleChromeCastVersion { get; }

		// @property (readonly, retain, nonatomic) NSString * playerState;
		[Export ("playerState", ArgumentSemantic.Retain)]
		string PlayerState { get; }

		// @property (retain, nonatomic) NSDictionary * metadata;
		[Export ("metadata", ArgumentSemantic.Retain)]
		NSDictionary Metadata { get; set; }

		// @property (nonatomic) CGSize naturalSize;
		[Export ("naturalSize", ArgumentSemantic.Assign)]
		CGSize NaturalSize { get; set; }

		// @property (readonly, retain, nonatomic) JWConfig * config;
		[Export ("config", ArgumentSemantic.Retain)]
		JWConfig Config { get; }

		// @property (readonly, nonatomic) NSInteger buffer;
		[Export ("buffer")]
		nint Buffer { get; }

		// @property (nonatomic) BOOL controls;
		[Export ("controls")]
		bool Controls { get; set; }

		// @property (nonatomic) BOOL displayLockScreenControls;
		[Export ("displayLockScreenControls")]
		bool DisplayLockScreenControls { get; set; }

		// @property (readonly, nonatomic) CGRect safeRegion;
		[Export ("safeRegion")]
		CGRect SafeRegion { get; }

		// @property (nonatomic) NSInteger currentQualityLevel;
		[Export ("currentQualityLevel")]
		nint CurrentQualityLevel { get; set; }

		// @property (readonly, retain, nonatomic) NSArray * levels;
		[Export ("levels", ArgumentSemantic.Retain)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] Levels { get; }

		// @property (nonatomic) NSInteger currentCaptions;
		[Export ("currentCaptions")]
		nint CurrentCaptions { get; set; }

		// @property (readonly, retain, nonatomic) NSArray * captionsList;
		[Export ("captionsList", ArgumentSemantic.Retain)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] CaptionsList { get; }

		// @property (nonatomic) NSInteger currentAudioTrack;
		[Export ("currentAudioTrack")]
		nint CurrentAudioTrack { get; set; }

		// @property (readonly, retain, nonatomic) NSArray * audioTracks;
		[Export ("audioTracks", ArgumentSemantic.Retain)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] AudioTracks { get; }

		// @property (nonatomic) NSInteger playlistIndex;
		[Export ("playlistIndex")]
		nint PlaylistIndex { get; set; }

		// -(instancetype)initWithConfig:(JWConfig *)config;
		[Export ("initWithConfig:")]
		IntPtr Constructor (JWConfig config);

		// -(instancetype)initWithConfig:(JWConfig *)config delegate:(id<JWPlayerDelegate>)delegate;
		[Export ("initWithConfig:delegate:")]
		IntPtr Constructor (JWConfig config, JWPlayerDelegate @delegate);

		// -(instancetype)initWithConfig:(JWConfig *)config delegate:(id<JWPlayerDelegate>)delegate drmDataSource:(id<JWDrmDataSource>)drmDataSource;
		[Export ("initWithConfig:delegate:drmDataSource:")]
		IntPtr Constructor (JWConfig config, JWPlayerDelegate @delegate, JWDrmDataSource drmDataSource);

		// -(void)play;
		[Export ("play")]
		void Play ();

		// -(void)pause;
		[Export ("pause")]
		void Pause ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(void)seek:(NSUInteger)position;
		[Export ("seek:")]
		void Seek (nuint position);

		// @property (retain, nonatomic) NSNumber * playbackPosition;
		[Export ("playbackPosition", ArgumentSemantic.Retain)]
		NSNumber PlaybackPosition { get; set; }

		// @property (nonatomic) double duration;
		[Export ("duration")]
		double Duration { get; set; }

		// @property (nonatomic) CGFloat volume;
		[Export ("volume")]
		nfloat Volume { get; set; }

		// @property (readonly, nonatomic) BOOL isInFullscreen;
		[Export ("isInFullscreen")]
		bool IsInFullscreen { get; }

		// @property (nonatomic) BOOL forceFullScreenOnLandscape;
		[Export ("forceFullScreenOnLandscape")]
		bool ForceFullScreenOnLandscape { get; set; }

		// @property (nonatomic) BOOL forceLandscapeOnFullScreen;
		[Export ("forceLandscapeOnFullScreen")]
		bool ForceLandscapeOnFullScreen { get; set; }

		// @property (nonatomic) BOOL pictureInPictureDisabled;
		[Export ("pictureInPictureDisabled")]
		bool PictureInPictureDisabled { get; set; }

		// -(void)enterFullScreen;
		[Export ("enterFullScreen")]
		void EnterFullScreen ();

		// -(void)exitFullScreen;
		[Export ("exitFullScreen")]
		void ExitFullScreen ();

		// -(void)togglePictureInPicture;
		[Export ("togglePictureInPicture")]
		void TogglePictureInPicture ();

		// -(void)load:(NSString *)file;
		[Export ("load:")]
		void Load (string file);

		// -(void)loadConfig:(JWConfig *)config;
		[Export ("loadConfig:")]
		void LoadConfig (JWConfig config);

		// -(void)loadPlaylist:(NSArray *)playlist;
		[Export ("loadPlaylist:")]
		// [Verify (StronglyTypedNSArray)]
		void LoadPlaylist (NSObject[] playlist);

		// -(void)playAd:(NSString *)tag;
		[Export ("playAd:")]
		void PlayAd (string tag);

		// -(void)playAd:(NSString *)tag onClient:(JWAdClient)adClient;
		[Export ("playAd:onClient:")]
		void PlayAd (string tag, JWAdClient adClient);

		// @property (nonatomic) BOOL openSafariOnAdClick;
		[Export ("openSafariOnAdClick")]
		bool OpenSafariOnAdClick { get; set; }

		// @property (readonly, retain, nonatomic) NSString * playerVersion;
		[Export ("playerVersion", ArgumentSemantic.Retain)]
		string PlayerVersion { get; }

		// @property (readonly, retain, nonatomic) NSString * playerEdition;
		[Export ("playerEdition", ArgumentSemantic.Retain)]
		string PlayerEdition { get; }

		// +(NSString *)SDKVersion;
		[Static]
		[Export ("SDKVersion")]
		//[Verify (MethodToProperty)]
		string SDKVersion { get; }

		// +(NSString *)SDKVersionToMinor;
		[Static]
		[Export ("SDKVersionToMinor")]
		//[Verify (MethodToProperty)]
		string SDKVersionToMinor { get; }
	}
}
