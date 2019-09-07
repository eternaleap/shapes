select a.ArticleName, a.TagName
from Articles a
left join ArticleTagsRelations r on a.ArticleId = r.ArticleId
left join Tags t on t.TagId = r.TagId