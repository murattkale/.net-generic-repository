//using Microsoft.Extensions.Caching.Distributed;
//using Microsoft.Extensions.Logging;
//using muratkale.Common;
//using muratkale.Data.EFModelContext;
//using muratkale.EFRepository;
//using muratkale.ElasticSearchRepository;
//using Nest;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace muratkale.Services
//{
//    public class StickerRepository : GenericRepository<Sticker>, IStickerRepository
//    {
//        private readonly IElasticSearchRepository<Sticker> _IElasticSearchRepo;
//        private readonly ElasticSearchRepository<Sticker> _ElasticSearchRepo;
//        private readonly IDistributedCache _distributedCache;
//        private readonly ILogger<StickerRepository> _logger;
//        public StickerRepository(
//            EFContext context
//            , IDistributedCache distributedCache
//            , ILogger<StickerRepository> logger
//            , IElasticSearchRepository<Sticker> _IElasticSearchRepo
//            ) : base(context)
//        {
//            this._logger = logger;
//            this._IElasticSearchRepo = _IElasticSearchRepo;
//            this._ElasticSearchRepo = new ElasticSearchRepository<Sticker>("sticker_test", "http://localhost:9200");
//            this._distributedCache = distributedCache;

//        }


//        public async Task<dynamic> Get(int? count)
//        {
//            //_logger.LogInformation("Hi from logger !");
//            //int[] dizi = new int[1];
//            //for (int i = 0; i < 3; i++)
//            //{
//            //    dizi[i] = i;
//            //}

//            int cacheTime = 10;
//            count = count ?? 10000;
//            string cacheKey = "redis_sticker";
//            List<Sticker> result;
//            var entry = await _distributedCache.GetAsync(cacheKey);
//            if (entry == null)
//            {
//                result = Where().Take((int)count).ToList();
//                entry = result.Serialize();
//                await _distributedCache.SetAsync(cacheKey,
//                    entry,
//                    new Microsoft.Extensions.Caching.Distributed.DistributedCacheEntryOptions()
//                    {
//                        SlidingExpiration = TimeSpan.FromSeconds(cacheTime),
//                        AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(cacheTime)
//                    });
//            }
//            else
//            {
//                var res = Encoding.UTF8.GetString(entry);
//                result = res.Deserialize<List<Sticker>>();
//            }

//            return result;
//        }

//        public IEnumerable<Sticker> getLastDataList()
//        {
//            var lastrow = _IElasticSearchRepo.SearchAll(new BaseSearchModel() { orderProp = "stickerId", order = SortOrder.Descending, }).FirstOrDefault();
//            var result = _IElasticSearchRepo.Search(new BaseSearchModel()
//            {
//                _NumericRangeQuery = new NumericRangeQuery()
//                {
//                    Name = "stickerID",
//                    //Boost = 1.1,
//                    Field = "stickerID",
//                    GreaterThan = lastrow == null ? 0 : lastrow.StickerId,
//                    //GreaterThanOrEqualTo = 1.1,
//                    //LessThan = 2.1,
//                    //LessThanOrEqualTo = 2.0,
//                    Relation = RangeRelation.Within
//                },
//                order = SortOrder.Descending,
//                orderProp = "stickerID",
//            });

//            return result;
//        }

//        //public string _getStickerDB()
//        //{
//        //    string message = "";
//        //    int pageCount = 100000;
//        //    int? id = 0;
//        //    while (true)
//        //    {
//        //        try
//        //        {
//        //            var result = _stickerRepo.Where().Take(pageCount);
//        //            var resultlast = _stickerRepo.Where().OrderByDescending(o => o.StickerId);
//        //            var lastrow = _ESStickerRepository.SearchAll(new BaseSearchModel() { orderProp = "stickerId", order = SortOrder.Descending, Size = 1 });
//        //            if (lastrow.Count() > 0)
//        //                id = lastrow.FirstOrDefault().StickerId;
//        //            if (id != 0)
//        //                result = _stickerRepo.Where(o => o.StickerId > id).Take(pageCount);

//        //            var datas = result.ToList();
//        //            if (datas.Count < 1)
//        //                continue;
//        //            //var esResult = _ESStickerRepository.BulkInsert(datas);
//        //        }
//        //        catch (Exception ex)
//        //        {
//        //            message += ex.InnerException;
//        //            continue;
//        //        }
//        //    }
//        //}

//        //public string _setApi()
//        //{
//        //    string message = "";
//        //    string XmlLink = APILinks.link_seoart;
//        //    XmlDocument xDoc = new XmlDocument();
//        //    int? page = 0;
//        //    var lastrow = _ESStickerRepository.SearchAll(new BaseSearchModel() { orderProp = "stickerID", order = SortOrder.Descending, Size = 1 }).FirstOrDefault();
//        //    if (lastrow != null)
//        //        page = lastrow.page;

//        //    string url = XmlLink;
//        //    while (true)
//        //    {
//        //        try
//        //        {
//        //            xDoc = new XmlDocument();
//        //            page++;
//        //            if (page > 1)
//        //                url = XmlLink + "?p=" + page;

//        //            xDoc.Load(url);

//        //            if (xDoc.SelectNodes("//tag").Count < 1)
//        //            {
//        //                Thread.Sleep(5000);
//        //                page--;
//        //                continue;
//        //            }
//        //            var tags = XDocument.Parse(xDoc.InnerXml).Descendants("tag").Select(o => new StickerModel
//        //            {
//        //                page = page,
//        //                StickerId = o.Element("id").Value.ToStr().Trim().ToInt(),
//        //                StickerName = o.Element("topic").Value.ToString().ToStr().Trim(),
//        //                StickerNameNonTrChar = o.Element("topic").Value.ToStr().Trim().ToLower().ClearTurkish(),
//        //                StickerVaryant = o.Elements("varyant").Select(oo => new StickerVaryant
//        //                {
//        //                    StickerId = o.Element("id").Value.ToStr().Trim().ToInt(),
//        //                    VaryantName = oo.Value != null ? oo.Value.ToStr().Trim() : "",
//        //                    VaryantUrl = oo.Value != null ? oo.Value.ToStr().Trim().ToLower().ClearTurkish() : ""
//        //                }).ToList()
//        //            }).ToList();

//        //            if (tags.Count < 100)
//        //            {
//        //                Thread.Sleep(5000);
//        //                page--;
//        //                continue;
//        //            }

//        //            var esResult = _ESStickerRepository.BulkInsert(tags);
//        //        }
//        //        catch (Exception ex)
//        //        {
//        //            message += ex.InnerException;
//        //            Thread.Sleep(5000);
//        //            continue;
//        //        }


//        //    }

//        //    return message;
//        //}

//    }
//}
