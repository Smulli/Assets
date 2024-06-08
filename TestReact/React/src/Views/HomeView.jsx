import Data from "../Assets/Data/data.json"
import RowCardContent from "../layouts/RowCardContent";

const updateData = Data.data[0].updateSection;
const csData = Data.data[0].comingSoonSection;

function HomeView() {
    return <div>
        <RowCardContent title="Social Today" contentData={updateData} />
        <RowCardContent title="Coming Soon" contentData={csData} />
    </div>
}

export default HomeView;