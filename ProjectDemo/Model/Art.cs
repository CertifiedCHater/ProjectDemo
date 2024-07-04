using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectDemo.Model;


// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Color
{
    public int h { get; set; }
    public int l { get; set; }
    public int s { get; set; }
    public double percentage { get; set; }
    public int population { get; set; }
}

public class Config
{
    public string iiif_url { get; set; }
    public string website_url { get; set; }
}

public class Contexts
{
    public List<string> groupings { get; set; }
}

public partial class Data
{
    public int id { get; set; }
    public string api_model { get; set; }
    public string api_link { get; set; }
    public bool is_boosted { get; set; }
    public string title { get; set; }
    public object alt_titles { get; set; }
    public Thumbnail thumbnail { get; set; }
    public string main_reference_number { get; set; }
    public bool has_not_been_viewed_much { get; set; }
    public int? boost_rank { get; set; }
    public int date_start { get; set; }
    public int date_end { get; set; }
    public string date_display { get; set; }
    public string date_qualifier_title { get; set; }
    public int? date_qualifier_id { get; set; }
    public string artist_display { get; set; }
    public string place_of_origin { get; set; }
    public string description { get; set; }
    public string short_description { get; set; }
    public string dimensions { get; set; }
    public List<DimensionsDetail> dimensions_detail { get; set; }
    public string medium_display { get; set; }
    public string inscriptions { get; set; }
    public string credit_line { get; set; }
    public string catalogue_display { get; set; }
    public string publication_history { get; set; }
    public string exhibition_history { get; set; }
    public string provenance_text { get; set; }
    public object edition { get; set; }
    public string publishing_verification_level { get; set; }
    public int internal_department_id { get; set; }
    public int? fiscal_year { get; set; }
    public object fiscal_year_deaccession { get; set; }
    public bool is_public_domain { get; set; }
    public bool is_zoomable { get; set; }
    public int max_zoom_window_size { get; set; }
    public string copyright_notice { get; set; }
    public bool has_multimedia_resources { get; set; }
    public bool has_educational_resources { get; set; }
    public bool has_advanced_imaging { get; set; }
    public double? colorfulness { get; set; }
    public Color color { get; set; }
    public double? latitude { get; set; }
    public double? longitude { get; set; }
    public string latlon { get; set; }
    public bool is_on_view { get; set; }
    public string on_loan_display { get; set; }
    public object gallery_title { get; set; }
    public object gallery_id { get; set; }
    public object nomisma_id { get; set; }
    public string artwork_type_title { get; set; }
    public int artwork_type_id { get; set; }
    public string department_title { get; set; }
    public string department_id { get; set; }
    public int? artist_id { get; set; }
    public string artist_title { get; set; }
    public List<object> alt_artist_ids { get; set; }
    public List<int> artist_ids { get; set; }
    public List<string> artist_titles { get; set; }
    public List<string> category_ids { get; set; }
    public List<string> category_titles { get; set; }
    public List<string> term_titles { get; set; }
    public string style_id { get; set; }
    public string style_title { get; set; }
    public List<string> alt_style_ids { get; set; }
    public List<string> style_ids { get; set; }
    public List<string> style_titles { get; set; }
    public string classification_id { get; set; }
    public string classification_title { get; set; }
    public List<string> alt_classification_ids { get; set; }
    public List<string> classification_ids { get; set; }
    public List<string> classification_titles { get; set; }
    public string subject_id { get; set; }
    public List<string> alt_subject_ids { get; set; }
    public List<string> subject_ids { get; set; }
    public List<string> subject_titles { get; set; }
    public string material_id { get; set; }
    public List<string> alt_material_ids { get; set; }
    public List<string> material_ids { get; set; }
    public List<string> material_titles { get; set; }
    public string technique_id { get; set; }
    public List<string> alt_technique_ids { get; set; }
    public List<string> technique_ids { get; set; }
    public List<string> technique_titles { get; set; }
    public List<string> theme_titles { get; set; }
    public string image_id { get; set; }
    public List<string> alt_image_ids { get; set; }
    public List<string> document_ids { get; set; }
    public List<string> sound_ids { get; set; }
    public List<object> video_ids { get; set; }
    public List<string> text_ids { get; set; }
    public List<object> section_ids { get; set; }
    public List<string> section_titles { get; set; }
    public List<object> site_ids { get; set; }
    public List<SuggestAutocompleteAll> suggest_autocomplete_all { get; set; }
    public DateTime source_updated_at { get; set; }
    public DateTime updated_at { get; set; }
    public DateTime timestamp { get; set; }
    public string suggest_autocomplete_boosted { get; set; }
}

public class DimensionsDetail
{
    public int? depth { get; set; }
    public int? width { get; set; }
    public int height { get; set; }
    public object diameter { get; set; }
    public string clarification { get; set; }
}

public class Info
{
    public string license_text { get; set; }
    public List<string> license_links { get; set; }
    public string version { get; set; }
}

public class Pagination
{
    public int total { get; set; }
    public int limit { get; set; }
    public int offset { get; set; }
    public int total_pages { get; set; }
    public int current_page { get; set; }
    public string next_url { get; set; }
}

public class Art
{
    public Pagination pagination { get; set; }
    public List<Data> data { get; set; }
    public Info info { get; set; }
    public Config config { get; set; }
}

public class SuggestAutocompleteAll
{
    public List<string> input { get; set; }
    public Contexts contexts { get; set; }
    public int? weight { get; set; }
}

public class Thumbnail
{
    public string lqip { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public string alt_text { get; set; }
}

[JsonSerializable(typeof(List<Art>))]
internal sealed partial class ArtContext : JsonSerializerContext
{

}

