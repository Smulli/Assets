import GridCard from "../components/GridCard";

export default function DeprecatedCardContent({ title, contentData }) {
    return <div className="container my-5">
        <div className="row w-100">
            <h1>- {title} -</h1>
            {
                contentData.map(contentSet => (
                    <div className="col-md-4" key={contentSet.id}>
                        <GridCard title={contentSet.title} content={contentSet.content} date={contentSet.date} btnText={contentSet.urlText} url={contentSet.url} />
                    </div>
                ))
            }
        </div>
    </div>
}