using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OutlookMessageSummary
{
    class Template
    {
        private string ConcString(object o) => o?.ToString() ?? "";

        // Reflecting/dictionary access with dynamic doesn't seem to work for interop.
        private Dictionary<string, object> DataFor(dynamic x)
        {
            var result = new Dictionary<string, object>
            {
                ["alternaterecipientallowed"] = x.AlternateRecipientAllowed,
                ["autoforwarded"] = x.AutoForwarded,
                ["autoresolvedwinner"] = x.AutoResolvedWinner,
                ["bcc"] = x.BCC,
                ["billinginformation"] = x.BillingInformation,
                ["body"] = x.Body,
                ["bodyformat"] = x.BodyFormat,
                ["categories"] = x.Categories,
                ["cc"] = x.CC,
                ["companies"] = x.Companies,
                ["conversationid"] = x.ConversationID,
                ["conversationindex"] = x.ConversationIndex,
                ["conversationtopic"] = x.ConversationTopic,
                ["creationtime"] = x.CreationTime,
                ["deferreddeliverytime"] = x.DeferredDeliveryTime,
                ["deleteaftersubmit"] = x.DeleteAfterSubmit,
                ["downloadstate"] = x.DownloadState,
                ["enablesharedattachments"] = x.EnableSharedAttachments,
                ["entryid"] = x.EntryID,
                ["expirytime"] = x.ExpiryTime,
                ["flagdueby"] = x.FlagDueBy,
                ["flagicon"] = x.FlagIcon,
                ["flagrequest"] = x.FlagRequest,
                ["flagstatus"] = x.FlagStatus,
                ["hascoversheet"] = x.HasCoverSheet,
                ["htmlbody"] = x.HTMLBody,
                ["importance"] = x.Importance,
                ["internetcodepage"] = x.InternetCodepage,
                ["isconflict"] = x.IsConflict,
                ["isipfax"] = x.IsIPFax,
                ["ismarkedastask"] = x.IsMarkedAsTask,
                ["lastmodificationtime"] = x.LastModificationTime,
                ["markfordownload"] = x.MarkForDownload,
                ["messageclass"] = x.MessageClass,
                ["mileage"] = x.Mileage,
                ["noaging"] = x.NoAging,
                ["originatordeliveryreportrequested"] = x.OriginatorDeliveryReportRequested,
                ["outlookinternalversion"] = x.OutlookInternalVersion,
                ["outlookversion"] = x.OutlookVersion,
                ["permission"] = x.Permission,
                ["permissionservice"] = x.PermissionService,
                ["readreceiptrequested"] = x.ReadReceiptRequested,
                ["receivedbyentryid"] = x.ReceivedByEntryID,
                ["receivedbyname"] = x.ReceivedByName,
                ["receivedonbehalfofentryid"] = x.ReceivedOnBehalfOfEntryID,
                ["receivedonbehalfofname"] = x.ReceivedOnBehalfOfName,
                ["receivedtime"] = x.ReceivedTime,
                ["recipientreassignmentprohibited"] = x.RecipientReassignmentProhibited,
                ["reminderoverridedefault"] = x.ReminderOverrideDefault,
                ["reminderplaysound"] = x.ReminderPlaySound,
                ["reminderset"] = x.ReminderSet,
                ["remindersoundfile"] = x.ReminderSoundFile,
                ["remindertime"] = x.ReminderTime,
                ["remotestatus"] = x.RemoteStatus,
                ["replyrecipientnames"] = x.ReplyRecipientNames,
                ["retentionexpirationdate"] = x.RetentionExpirationDate,
                ["saved"] = x.Saved,
                ["senderemailaddress"] = x.SenderEmailAddress,
                ["senderemailtype"] = x.SenderEmailType,
                ["sendername"] = x.SenderName,
                ["sensitivity"] = x.Sensitivity,
                ["sent"] = x.Sent,
                ["senton"] = x.SentOn,
                ["sentonbehalfofname"] = x.SentOnBehalfOfName,
                ["size"] = x.Size,
                ["subject"] = x.Subject,
                ["submitted"] = x.Submitted,
                ["taskcompleteddate"] = x.TaskCompletedDate,
                ["taskduedate"] = x.TaskDueDate,
                ["taskstartdate"] = x.TaskStartDate,
                ["tasksubject"] = x.TaskSubject,
                ["to"] = x.To,
                ["todotaskordinal"] = x.ToDoTaskOrdinal,
                ["votingoptions"] = x.VotingOptions,
                ["votingresponse"] = x.VotingResponse,
                ["alternaterecipientallowed"] = x.AlternateRecipientAllowed,
                ["autoforwarded"] = x.AutoForwarded,
                ["autoresolvedwinner"] = x.AutoResolvedWinner,
                ["bcc"] = x.BCC,
                ["billinginformation"] = x.BillingInformation,
                ["body"] = x.Body,
                ["bodyformat"] = x.BodyFormat,
                ["categories"] = x.Categories,
                ["cc"] = x.CC,
                ["companies"] = x.Companies,
                ["conversationid"] = x.ConversationID,
                ["conversationindex"] = x.ConversationIndex,
                ["conversationtopic"] = x.ConversationTopic,
                ["creationtime"] = x.CreationTime,
                ["deferreddeliverytime"] = x.DeferredDeliveryTime,
                ["deleteaftersubmit"] = x.DeleteAfterSubmit,
                ["downloadstate"] = x.DownloadState,
                ["enablesharedattachments"] = x.EnableSharedAttachments,
                ["entryid"] = x.EntryID,
                ["expirytime"] = x.ExpiryTime,
                ["flagdueby"] = x.FlagDueBy,
                ["flagicon"] = x.FlagIcon,
                ["flagrequest"] = x.FlagRequest,
                ["flagstatus"] = x.FlagStatus,
                ["hascoversheet"] = x.HasCoverSheet,
                ["htmlbody"] = x.HTMLBody,
                ["importance"] = x.Importance,
                ["internetcodepage"] = x.InternetCodepage,
                ["isconflict"] = x.IsConflict,
                ["isipfax"] = x.IsIPFax,
                ["ismarkedastask"] = x.IsMarkedAsTask,
                ["lastmodificationtime"] = x.LastModificationTime,
                ["markfordownload"] = x.MarkForDownload,
                ["messageclass"] = x.MessageClass,
                ["mileage"] = x.Mileage,
                ["noaging"] = x.NoAging,
                ["originatordeliveryreportrequested"] = x.OriginatorDeliveryReportRequested,
                ["outlookinternalversion"] = x.OutlookInternalVersion,
                ["outlookversion"] = x.OutlookVersion,
                ["permission"] = x.Permission,
                ["permissionservice"] = x.PermissionService,
                ["readreceiptrequested"] = x.ReadReceiptRequested,
                ["receivedbyentryid"] = x.ReceivedByEntryID,
                ["receivedbyname"] = x.ReceivedByName,
                ["receivedonbehalfofentryid"] = x.ReceivedOnBehalfOfEntryID,
                ["receivedonbehalfofname"] = x.ReceivedOnBehalfOfName,
                ["receivedtime"] = x.ReceivedTime,
                ["recipientreassignmentprohibited"] = x.RecipientReassignmentProhibited,
                ["reminderoverridedefault"] = x.ReminderOverrideDefault,
                ["reminderplaysound"] = x.ReminderPlaySound,
                ["reminderset"] = x.ReminderSet,
                ["remindersoundfile"] = x.ReminderSoundFile,
                ["remindertime"] = x.ReminderTime,
                ["remotestatus"] = x.RemoteStatus,
                ["replyrecipientnames"] = x.ReplyRecipientNames,
                ["retentionexpirationdate"] = x.RetentionExpirationDate,
                ["saved"] = x.Saved,
                ["senderemailaddress"] = x.SenderEmailAddress,
                ["senderemailtype"] = x.SenderEmailType,
                ["sendername"] = x.SenderName,
                ["sensitivity"] = x.Sensitivity,
                ["sent"] = x.Sent,
                ["senton"] = x.SentOn,
                ["sentonbehalfofname"] = x.SentOnBehalfOfName,
                ["size"] = x.Size,
                ["subject"] = x.Subject,
                ["submitted"] = x.Submitted,
                ["taskcompleteddate"] = x.TaskCompletedDate,
                ["taskduedate"] = x.TaskDueDate,
                ["taskstartdate"] = x.TaskStartDate,
                ["tasksubject"] = x.TaskSubject,
                ["to"] = x.To,
                ["todotaskordinal"] = x.ToDoTaskOrdinal,
                ["votingoptions"] = x.VotingOptions,
                ["votingresponse"] = x.VotingResponse
            };
            if (null != x.Sender)
            {
                result["sender.address"] = x.Sender.Address;
                result["sender.id"] = x.Sender.ID;
                result["sender.name"] = x.Sender.Name;
                result["sender.type"] = x.Sender.Type;
            }
            if (null != x.SendUsingAccount)
            {
                result["sendusingaccount.displayname"] = x.SendUsingAccount.DisplayName;
                result["sendusingaccount.exchangemailboxservername"] = x.SendUsingAccount.ExchangeMailboxServerName;
                result["sendusingaccount.exchangemailboxserverversion"] = x.SendUsingAccount.ExchangeMailboxServerVersion;
                result["sendusingaccount.smtpaddress"] = x.SendUsingAccount.SmtpAddress;
                result["sendusingaccount.username"] = x.SendUsingAccount.UserName;
            }
            if (null != x.SendUsingAccount.CurrentUser)
            {
                result["sendusingaccount.currentuser.address"] = x.SendUsingAccount.CurrentUser.Address;
                result["sendusingaccount.currentuser.entryid"] = x.SendUsingAccount.CurrentUser.EntryID;
                result["sendusingaccount.currentuser.index"] = x.SendUsingAccount.CurrentUser.Index;
                result["sendusingaccount.currentuser.meetingresponsestatus"] = x.SendUsingAccount.CurrentUser.MeetingResponseStatus;
                result["sendusingaccount.currentuser.name"] = x.SendUsingAccount.CurrentUser.Name;
                result["sendusingaccount.currentuser.resolved"] = x.SendUsingAccount.CurrentUser.Resolved;
                result["sendusingaccount.currentuser.sendable"] = x.SendUsingAccount.CurrentUser.Sendable;
                result["sendusingaccount.currentuser.trackingstatus"] = x.SendUsingAccount.CurrentUser.TrackingStatus;
                result["sendusingaccount.currentuser.trackingstatustime"] = x.SendUsingAccount.CurrentUser.TrackingStatusTime;
            }

            result["attachments.displayname"] = "";
            result["attachments.filename"] = "";
            result["attachments.index"] = "";
            result["attachments.pathname"] = "";
            result["attachments.position"] = "";
            result["attachments.size"] = "";
            foreach (dynamic a in x.Attachments)
            {
                result["attachments.displayname"] += " " + ConcString(a.DisplayName);
                result["attachments.filename"] += " " + ConcString(a.FileName);
                result["attachments.index"] += " " + ConcString(a.Index);
                result["attachments.pathname"] += " " + ConcString(a.PathName);
                result["attachments.position"] += " " + ConcString(a.Position);
                result["attachments.size"] += " " + ConcString(a.Size);
            }

            result["recipients.address"] = "";
            result["recipients.entryid"] = "";
            result["recipients.index"] = "";
            result["recipients.meetingresponsestatus"] = "";
            result["recipients.name"] = "";
            result["recipients.resolved"] = "";
            result["recipients.sendable"] = "";
            result["recipients.trackingstatus"] = "";
            result["recipients.trackingstatustime"] = "";
            foreach (dynamic r in x.Recipients)
            {
                result["recipients.address"] += " " + ConcString(r.Address);
                result["recipients.entryid"] += " " + ConcString(r.EntryID);
                result["recipients.index"] += " " + ConcString(r.Index);
                result["recipients.meetingresponsestatus"] += " " + ConcString(r.MeetingResponseStatus);
                result["recipients.name"] += " " + ConcString(r.Name);
                result["recipients.resolved"] += " " + ConcString(r.Resolved);
                result["recipients.sendable"] += " " + ConcString(r.Sendable);
                result["recipients.trackingstatus"] += " " + ConcString(r.TrackingStatus);
                result["recipients.trackingstatustime"] += " " + ConcString(r.TrackingStatusTime);
            }
            return result;
        }

        private List<object> Items = new List<object>();
        private string TemplateBody = "";
        private Dictionary<string, object> Data;

        private void ProcessTemplate(string templateBody)
        {
            if (string.IsNullOrEmpty(templateBody))
            {
                TemplateBody = "";
                return;
            }
            Items = new List<object>();
            TemplateBody = templateBody;
            templateBody = templateBody.Replace("{{", "");
            int idx = 0;
            foreach (Match match in Regex.Matches(templateBody, "({([a-zA-z.]+))"))
            {
                if (1 < match.Groups.Count)
                {
                    string wholeMatch = match.Groups[1].Value;
                    string key = match.Groups[2].Value;
                    if (string.IsNullOrEmpty(wholeMatch) && string.IsNullOrEmpty(key))
                    {
                        continue;
                    }
                    key = key.ToLower();
                    if (Data.ContainsKey(key))
                    {
                        TemplateBody = TemplateBody.Replace(wholeMatch, "{" + idx.ToString());
                        idx++;
                        Items.Add(Data[key]);
                    }
                }
            }
        }

        public Template(dynamic item, string namedTemplate)
        {
            Data = DataFor(item);
            ProcessTemplate(namedTemplate);
        }

        override public string ToString() => String.Format(TemplateBody, Items.ToArray());
    }
}
