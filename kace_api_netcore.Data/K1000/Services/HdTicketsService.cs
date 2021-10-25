using kace_api_netcore.Data.Extensions;
using kace_api_netcore.Data.K1000.Dtos;
using kace_api_netcore.Data.K1000.Interfaces;
using kace_api_netcore.Data.Models;
using kace_api_netcore.Entities.K1000;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace kace_api_netcore.Data.K1000.Services
{
    public class HdTicketsService : IHdTicketsService
    {
        private readonly ORG1Context _context;

        public HdTicketsService(ORG1Context context)
        {
            _context = context;
        }

        public Task<PagedModel<HdTicketsDto>> GetPaginatedHdTicketList(PaginatedHdTicketListParams queryParams, string dept, CancellationToken cancellationToken)
        {
            var query = _context.HdTicket
                .Where(t => t.HdQueueId == 1)
                .Select(t => new HdTicketsDto
                {
                    Ticket = t.Id,
                    Title = t.Title,
                    Priority = t.Priority.Name,
                    Owner = t.Owner.FullName,
                    Submitter = t.Submitter.FullName,
                    Asset = t.Asset.Name,
                    Status = t.Status.Name,
                    ReferredTo = t.CustomFieldValue5,
                    UserName = t.Owner.UserName,
                    Dept = t.CustomFieldValue1,
                    Location = t.CustomFieldValue2,
                    PriOrd = t.Priority.Ordinal,
                    StatOrd = t.Status.Ordinal,
                    Created = t.Created,
                    Modified = t.Modified,
                    DueDate = t.DueDate
                });

            if (queryParams.ExcludedStatuses != null)
            {
                string[] excludedList = queryParams.ExcludedStatuses.Split(',');

                query = excludedList
                    .Aggregate(query, (current, status) => current.Where(t => t.Status != status));
            }

            // IT gets to see all dept tickets
            // Other departments only see their tickets
            if (dept != "Information Technology") query = query.Where(t => t.Dept.Contains(dept));

            if (queryParams.Assignee != null)
            {
                query = query.Where(t => t.UserName == queryParams.Assignee);
            }

            if (queryParams.Software != null)
            {
                query = query.Where(t => t.Asset == queryParams.Software);
            }

            if (queryParams.ReferredTo != null)
            {
                query = query.Where(t => t.ReferredTo == queryParams.ReferredTo);
            }

            if (queryParams.Department != null)
            {
                query = query.Where(t => t.Dept == queryParams.Department);
            }

            if (queryParams.Location != null)
            {
                query = query.Where(t => t.Location == queryParams.Location);
            }

            var orderedQuery = query.OrderBy(t => 0);

            var sortFields = GetSortFieldList(queryParams.Sort);

            orderedQuery = sortFields?.Aggregate(orderedQuery, (current, sortField) =>
                               sortField.Field switch
                               {
                                   "ticket" => (sortField.SortDesc
                                       ? current.ThenByDescending(t => t.Ticket)
                                       : current.ThenBy(t => t.Ticket)),
                                   "title" => (sortField.SortDesc
                                       ? current.ThenByDescending(t => t.Title)
                                       : current.ThenBy(t => t.Title)),
                                   "priority" => (sortField.SortDesc
                                       ? current.ThenByDescending(t => t.PriOrd)
                                       : current.ThenBy(t => t.PriOrd)),
                                   "status" => (sortField.SortDesc
                                       ? current.ThenByDescending(t => t.StatOrd)
                                       : current.ThenBy(t => t.StatOrd)),
                                   "owner" => (sortField.SortDesc
                                       ? current.ThenByDescending(t => t.Owner)
                                       : current.ThenBy(t => t.Owner)),
                                   "submitter" => (sortField.SortDesc
                                       ? current.ThenByDescending(t => t.Submitter)
                                       : current.ThenBy(t => t.Submitter)),
                                   "asset" => (sortField.SortDesc
                                       ? current.ThenByDescending(t => t.Asset)
                                       : current.ThenBy(t => t.Asset)),
                                   "referredto" => (sortField.SortDesc
                                       ? current.ThenByDescending(t => t.ReferredTo)
                                       : current.ThenBy(t => t.ReferredTo)),
                                   "dept" => (sortField.SortDesc
                                       ? current.ThenByDescending(t => t.Dept)
                                       : current.ThenBy(t => t.Dept)),
                                   "location" => (sortField.SortDesc
                                       ? current.ThenByDescending(t => t.Location)
                                       : current.ThenBy(t => t.Location)),
                                   "created" => (sortField.SortDesc
                                       ? current.ThenByDescending(t => t.Created)
                                       : current.ThenBy(t => t.Created)),
                                   "modified" => (sortField.SortDesc
                                       ? current.ThenByDescending(t => t.Modified)
                                       : current.ThenBy(t => t.Modified)),
                                   _ => current
                               }
                           ) ?? orderedQuery;

            if (sortFields == null || sortFields.All(s => s.Field != "owner"))
            {
                orderedQuery = orderedQuery.ThenBy(t => t.Owner);
            }

            if (sortFields == null || sortFields.All(s => s.Field != "priority"))
            {
                orderedQuery = orderedQuery.ThenBy(t => t.PriOrd);
            }

            if (sortFields == null || sortFields.All(s => s.Field != "status"))
            {
                orderedQuery = orderedQuery.ThenBy(t => t.StatOrd);
            }

            return orderedQuery
                .AsNoTracking()
                .PaginateAsync(queryParams.Page, queryParams.PerPage, cancellationToken);
        }

        public Task<HdTicketsDto> GetHdTicketById(long id)
        {
            return _context.HdTicket
                .AsNoTracking()
                .Where(t => t.Id == id)
                .Select(t => new HdTicketsDto
                {
                    Ticket = t.Id,
                    Title = t.Title,
                    Priority = t.Priority.Name,
                    Owner = t.Owner.FullName,
                    Submitter = t.Submitter.FullName,
                    Asset = t.Asset.Name,
                    Status = t.Status.Name,
                    ReferredTo = t.CustomFieldValue5,
                    UserName = t.Owner.UserName,
                    Dept = t.CustomFieldValue1,
                    Location = t.CustomFieldValue2,
                    PriOrd = t.Priority.Ordinal,
                    StatOrd = t.Status.Ordinal,
                    Created = t.Created,
                    Modified = t.Modified
                })
                .FirstOrDefaultAsync();
        }

        public async Task<TicketInfoDto> GetLatestHdTicketCommentByTicketId(long id, string dept)
        {
            var info = await _context.HdTicketChange
                .Select(c => new TicketInfoDto
                {
                    Ticket = c.HdTicket.Id,
                    Summary = c.HdTicket.Summary,
                    Comment = c.Comment,
                    Timestamp = c.Timestamp,
                    Commenter = c.User.FullName,
                    OwnersOnly = c.OwnersOnly
                })
                .Where(c => c.Ticket == id)
                .Where(c => c.Comment != null)
                .Where(c => c.Comment != "")
                .Where(c => dept == "Information Technology" ||
                            c.OwnersOnly == 0) // Only IT can see Owners Only comments
                .OrderByDescending(c => c.Timestamp)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (info == null)
            {
                return null;
            }

            info.Summary = FixKaceFormatting(info.Summary);
            info.Comment = FixKaceFormatting(info.Comment);

            return info;
        }

        private static string FixKaceFormatting(string value)
        {
            const string pattern = @"<p>\s*</p>";

            value = value.Replace("/packages/hd_attachments", "https://cty-k1k.co.humboldt.ca.us/packages/hd_attachments");
            value = Regex.Replace(value, pattern, "");

            return value;
        }

        private List<SortField> GetSortFieldList(string sort)
        {
            var sortArray = sort?.Split(',');

            return sortArray?.Select(item => new SortField(item))
                .ToList();
        }
    }
}
