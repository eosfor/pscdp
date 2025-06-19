import-module "PSQuickGraph"
import-module "pscdp.dll"

$res = Start-Crawling -Url "https://azazello.darkcity.dev"
Export-Graph -Graph $res.Graph Format Vega_ForceDirected -Path "/tmp/force.html"
/tmp/force.html