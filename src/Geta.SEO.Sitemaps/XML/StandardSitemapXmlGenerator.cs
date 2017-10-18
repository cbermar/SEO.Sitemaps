﻿using EPiServer;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Routing;
using Geta.SEO.Sitemaps.Repositories;
using Geta.SEO.Sitemaps.Utils;

namespace Geta.SEO.Sitemaps.XML
{
    [ServiceConfiguration(typeof(IStandardSitemapXmlGenerator))]
    public class StandardSitemapXmlGenerator : SitemapXmlGenerator, IStandardSitemapXmlGenerator
    {
        public StandardSitemapXmlGenerator(ISitemapRepository sitemapRepository, IContentRepository contentRepository, UrlResolver urlResolver, ISiteDefinitionRepository siteDefinitionRepository, ILanguageBranchRepository languageBranchRepository, IContentFilter contentFilter, IContentLoader contentLoader) : base(sitemapRepository, contentRepository, urlResolver, siteDefinitionRepository, languageBranchRepository, contentFilter, contentLoader)
        {
        }
    }
}