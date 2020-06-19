
namespace MyPlayStation.API
{
    public class ClientConstants
    {
        /// <summary>
        /// Url to the Sony PSN login web page
        /// </summary>
        public const string LoginUrl = "https://account.sonyentertainmentnetwork.com/";

        /// <summary>
        /// The JavaScript that is injected into the Sony PSN login web page to get the NPSSO token
        /// that can then be used to request authentication tokens.
        /// </summary>
        public const string LoginJavaScript =
            "(function(open) {" +
                "XMLHttpRequest.prototype.open = function( method, url, async, user, pass)" +
                "{" +
                    "this.addEventListener( 'readystatechange', function() {" +
                        "if( this.readyState == XMLHttpRequest.DONE )" +
                        "{" +
                            "let response = JSON.parse( this.responseText );" +
                            "if( response && 'npsso' in response) {" +
                                "console.log( 'Found npsso:', response.npsso );" +
                                "invokeCallback( response.npsso )" +
                            "}" +
                        "}" +
                    "}, false);" +

                    "open.call( this, method, url, async, user, pass );" +
                "};" +
            "})(XMLHttpRequest.prototype.open);";

        public const string AppContext = "inapp_ios";
        public const string Id = "ebee17ac-99fd-487c-9b1e-18ef50c39ab5";
        public const string Duid = "0000000d00040080027BC1C3FBB84112BFC9A4300A78E96A";
        public const string Secret = "e4Ru_s*LrL4_B2BD";
        public const string Scope = "kamaji:get_players_met kamaji:get_account_hash kamaji:activity_feed_submit_feed_story kamaji:activity_feed_internal_feed_submit_story kamaji:activity_feed_get_news_feed kamaji:communities kamaji:game_list kamaji:ugc:distributor oauth:manage_device_usercodes psn:sceapp user:account.profile.get user:account.attributes.validate user:account.settings.privacy.get kamaji:activity_feed_set_feed_privacy kamaji:satchel kamaji:satchel_delete user:account.profile.update";
        public const string RedirectUri = "com.playstation.PlayStationApp://redirect";
    }
}
