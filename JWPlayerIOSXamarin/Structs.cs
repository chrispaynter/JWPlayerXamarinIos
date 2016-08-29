namespace JWPlayerIOSXamarin
{
	public enum JWAdClient : uint
	{
		vastPlugin = 1,
		googIMA = 2
	}

	public enum JWEdgeStyle : uint
	{
		none,
		dropshadow,
		raised,
		depressed,
		uniform
	}

	public enum JWPremiumSkin : uint
	{
		Seven = 0,
		Beelden,
		Bekle,
		Five,
		Glow,
		Roundster,
		Stormtrooper,
		Vapor,
		Six
	}

	public enum JWStretching : uint
	{
		Uniform = 0,
		ExactFit,
		Fill,
		None
	}

	public enum JWCastingService : uint
	{
		googleChromeCast = 1
	}

	public enum JWEncryption : uint
	{
		JWFairPlay = 0
	}
}
