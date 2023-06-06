﻿
using System.Collections.Generic;


namespace SAM.Game.HLTB
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Datum
    {
        public int count { get; set; }
        public int game_id { get; set; }
        public string game_name { get; set; }
        public int game_name_date { get; set; }
        public string game_alias { get; set; }
        public string game_type { get; set; }
        public string game_image { get; set; }
        public int comp_lvl_combine { get; set; }
        public int comp_lvl_sp { get; set; }
        public int comp_lvl_co { get; set; }
        public int comp_lvl_mp { get; set; }
        public int comp_lvl_spd { get; set; }
        public int comp_main { get; set; }
        public int comp_plus { get; set; }
        public int comp_100 { get; set; }
        public int comp_all { get; set; }
        public int comp_main_count { get; set; }
        public int comp_plus_count { get; set; }
        public int comp_100_count { get; set; }
        public int comp_all_count { get; set; }
        public int invested_co { get; set; }
        public int invested_mp { get; set; }
        public int invested_co_count { get; set; }
        public int invested_mp_count { get; set; }
        public int count_comp { get; set; }
        public int count_speedrun { get; set; }
        public int count_backlog { get; set; }
        public int count_review { get; set; }
        public int review_score { get; set; }
        public int count_playing { get; set; }
        public int count_retired { get; set; }
        public string profile_dev { get; set; }
        public int profile_popular { get; set; }
        public int profile_steam { get; set; }
        public string profile_platform { get; set; }
        public int release_world { get; set; }
    }

    public class Root
    {
        public string color { get; set; }
        public string title { get; set; }
        public string category { get; set; }
        public int count { get; set; }
        public int pageCurrent { get; set; }
        public int pageTotal { get; set; }
        public int pageSize { get; set; }
        public List<Datum> data { get; set; }
        public List<object> userData { get; set; }
        public object displayModifier { get; set; }
    }


}
