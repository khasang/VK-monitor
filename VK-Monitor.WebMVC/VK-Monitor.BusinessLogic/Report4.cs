using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VK_Monitor.BusinessLogic.Interfaces;
using VK_Monitor.Domain.Models;
using VkNet.Enums.SafetyEnums;

namespace VK_Monitor.BusinessLogic
{
    public class Report4 : IReport
    {
        public ReportModel GetData(IVkService vkRepository, ulong userId)
        {

            //ReportModel report = new ReportModel();

            //List<Group> groupList = new List<Group>();

            //var groups = vkRepository.GetGroups((long)userId);

            //foreach (var group in groups)
            //{
            //    var wallPosts = vkRepository.GetWallRecords(group.Id);
            //    foreach (var post in wallPosts.WallPosts)
            //    {
            //        if (vkRepository.IsLiked(LikeObjectType.Post, itemId: (long)post.Id, userId: (long)userId))
            //            report.Answer.Add("posts", post.Text);

            //        var comments = vkRepository.GetPostComments(group.Id, (long)post.Id);

            //        foreach (var comment in comments)
            //        {
            //            if (vkRepository.IsSameAuthor(comment.Id, (long)userId))
            //            {
            //                report.Answer.Add("comments", comment.Text);
            //            }

            //            if (vkRepository.IsLiked(LikeObjectType.Comment, itemId: comment.Id, userId: (long)userId))
            //            {
            //                report.Answer.Add("comments", comment.Text);
            //            }
            //        }
            //    }

            //    var group = new Group() { };
            //    groupList.Add(group);
            //}

            //report.Answer.Add("groups", groupList);
            //return report;
            return null;
        }
    }
}
