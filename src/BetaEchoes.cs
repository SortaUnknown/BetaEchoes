using BepInEx;
using System.Security.Permissions;

#pragma warning disable CS0618 //Type or member is obsolete
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
#pragma warning restore CS0618 //Type or member is obsolete

namespace BetaEchoes
{
    [BepInPlugin("HelloThere.BetaEchoes", "Beta Echoes", "1.1")]
    public class BetaEchoes : BaseUnityPlugin
    {
        public void OnEnable()
        {
            On.GhostConversation.AddEvents += GhostEventPatch;
        }

        static void GhostEventPatch(On.GhostConversation.orig_AddEvents orig, GhostConversation self)
        {
            if (self.ghost.room.game.GetStorySession.saveStateNumber == MoreSlugcats.MoreSlugcatsEnums.SlugcatStatsName.Saint) return;
            switch(self.id.value)
            {
                case "Ghost_CC":
                    self.events.Add(new Conversation.TextEvent(self, 0, "It is strange... ", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Something still holds us here. Even after all this time...<LINE>Some did go. Us, unlucky few, are gone but perpetually returning.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "The sky is...different now.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "And it is much quieter...", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "But the fields...", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "We do not need eyes to know that the grasses still sway gently in the winds.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "The paths of existence are surprising.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "To have grasped the infinities of time and space,<LINE>the boundless fractal planes of spirit and reality...<LINE>And yet here we are, contemplating these same fields as we once did,", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "...talking to some sort of rodent.", 10));
                    break;
                case "Ghost_SI":
                    self.events.Add(new Conversation.TextEvent(self, 0, "We feel your presence, little creature.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Your attunement has become... closer to ours, yes.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "And you can speak... Or listen.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "To a... being like you, it is an unimaginable gift.<LINE>Though a gift that does nothing for your struggle.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "It can all fade, like a morning mist beneath the glory of the sun.<LINE>We found a way.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "It cost us dearly, but we found a way.", 10));
                    break;
                case "Ghost_LF":
                    self.events.Add(new Conversation.TextEvent(self, 0, "Oh, I beg! Don't ever mind!", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "I'm only walking, grazing the fields of beyond what you can imagine!", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "No matter, just barge right on in!", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Never would I claim that *creatures*,<LINE>of *flesh* and *blood*, were...annoying!", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Never would I remind, that this is a holy place!<LINE>That it was, before my ancestors ancestors ancestors fought<LINE>wars for magnificence and splendor, with... *sticks*!", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "I wouldn't assert, that I *can* indeed be distracted,<LINE>because I am *not* a god. Merely... Not a mortal.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Oh how could I ever ask, why thing went the way they did?<LINE>Why when we left, for right, for better, I was stuck, *stumbling*<LINE>on the *threshold* of everlasting serenity?", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Here, among grime and dirt, not feeling, but watching.<LINE>As Iterators impotently churn and fray, a disgrace to the<LINE>legacy of which ruin my brethren are blissfully ignorant.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "As bugs crawl on the holy stones of ancient glory.", 10));
                    break;
                case "Ghost_SH":
                    self.events.Add(new Conversation.TextEvent(self, 0, "You have no name.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "I once had! I was embalmed, adorned, readied for a journey.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "There was laughter and tears. My name was sung, loud and clear.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Did they know? That I didn't quite leave, didn't quite stay?", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Should I be ashamed? That I stay close to where my memories are kept?", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Should I be ashamed? That now, I envy your prison...", 10));
                    break;
                case "Ghost_UW":
                    self.events.Add(new Conversation.TextEvent(self, 0, "From up here, one can survery the misdirection of our progress.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Behold an empty husk of a land! Populated only by storms, ruins and abominations...", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Present company excepted, of course.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Most of us have forgotten this place. Corporeal matters seem so distant now...<LINE>As viewed through veils upon veils. They are all through to the other side.<LINE>Me... I see veils, in both directions.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "So I like to come here, close to where we used to live. Perhaps... I sat here,<LINE>still inside my vessel of flesh, and watched a sunset.<LINE>It's too long ago to remember. ", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Never-ending cycles within cycles.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "But as far as we go... it is important to remember where we are from.<LINE>I was the Count of 2 living block. I had children. ", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Perhaps it's only important to me because I was unable to go.<LINE>Perhaps... I was unable to go because I still considered those things important.", 10));
                    break;
                case "Ghost_SB":
                    self.events.Add(new Conversation.TextEvent(self, 0, "A little beast.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "May I ask... Do you eat?", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Crunch crunch, yes? Ha!", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "So strange.", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "We ate, we did eat! Or was it merely our bodies?", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Ha! To you, there is no difference I suppose!", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "To tear flesh from a living being... grind it<LINE>betweeen ones mouthbones into component parts...", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Dissolve those parts in a cauldron of acid<LINE>within one's self, extracting its essence...", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "Ha! Ha! So disturbing!", 10));
                    self.events.Add(new Conversation.TextEvent(self, 0, "So fascinating!", 10));
                    break;
                default:
                    orig.Invoke(self);
                    break;
            }
        }
    }
}
