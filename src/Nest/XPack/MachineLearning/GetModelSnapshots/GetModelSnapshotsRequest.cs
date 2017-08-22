using System;
using Newtonsoft.Json;

namespace Nest
{
	/// <summary>
	/// A request to retrieve usage information for Machine Learning jobs.
	/// </summary>
	public partial interface IGetModelSnapshotsRequest
	{
		/// <summary>
		/// If true, the results are sorted in descending order.
		/// </summary>
		[JsonProperty("desc")]
		bool? Desc { get; set; }

		/// <summary>
		/// Returns snapshots with timestamps earlier than this time.
		/// </summary>
		[JsonProperty("end")]
		[JsonConverter(typeof(EpochSecondsDateTimeJsonConverter))]
		DateTimeOffset? End { get; set; }

		/// <summary>
		/// Specifies pagination for the snapshots
		/// </summary>
		[JsonProperty("page")]
		IPage Page { get; set; }

		/// <summary>
		/// Specifies the sort field for the requested snapshots. By default, snapshots are sorted by their timestamp.
		/// </summary>
		[JsonProperty("sort")]
		Field Sort { get; set; }

		/// <summary>
		/// Returns snapshots with timestamps after this time.
		/// </summary>
		[JsonProperty("start")]
		[JsonConverter(typeof(EpochSecondsDateTimeJsonConverter))]
		DateTimeOffset? Start { get; set; }
	}

	/// <inheritdoc />
	public partial class GetModelSnapshotsRequest
	{
		/// <inheritdoc />
		public bool? Desc { get; set; }

		/// <inheritdoc />
		public DateTimeOffset? End { get; set; }

		/// <inheritdoc />
		public IPage Page { get; set; }

		/// <inheritdoc />
		public Field Sort { get; set; }

		/// <inheritdoc />
		public DateTimeOffset? Start { get; set; }
	}

	/// <inheritdoc />
	[DescriptorFor("XpackMlGetModelSnapshots")]
	public partial class GetModelSnapshotsDescriptor
	{
		bool? IGetModelSnapshotsRequest.Desc { get; set; }
		DateTimeOffset? IGetModelSnapshotsRequest.End { get; set; }
		IPage IGetModelSnapshotsRequest.Page { get; set; }
		Field IGetModelSnapshotsRequest.Sort { get; set; }
		DateTimeOffset? IGetModelSnapshotsRequest.Start { get; set; }

		/// <inheritdoc />
		public GetModelSnapshotsDescriptor Desc(bool desc = true) => Assign(a => a.Desc = desc);

		/// <inheritdoc />
		public GetModelSnapshotsDescriptor End(DateTimeOffset end) => Assign(a => a.End = end);

		/// <inheritdoc />
		public GetModelSnapshotsDescriptor Page(Func<PageDescriptor, IPage> selector) =>
			Assign(a => a.Page = selector?.Invoke(new PageDescriptor()));

		/// <inheritdoc />
		public GetModelSnapshotsDescriptor Sort(Field field) => Assign(a => a.Sort = field);

		/// <inheritdoc />
		public GetModelSnapshotsDescriptor Start(DateTimeOffset end) => Assign(a => a.Start = end);
	}
}
