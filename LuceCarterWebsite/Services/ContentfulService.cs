using Contentful.Core;
using Contentful.Core.Models;
using LuceCarterWebsite.Models;

namespace LuceCarterWebsite.Services;

public class ContentfulService
{
    private ContentfulClient _contentfulClient;

    public ContentfulService(ContentfulOptions contentfulOptions)
    {
        var httpClient = new HttpClient();
        _contentfulClient = new ContentfulClient(httpClient, contentfulOptions.DeliveryApiKey,
            contentfulOptions.PreviewApiKey, contentfulOptions.SpaceId);
    }

    public async Task<ContentfulCollection<BlogPost>> GetEntries()
    {
        var entries = await _contentfulClient.GetEntries<BlogPost>();
        return entries;
    }
}