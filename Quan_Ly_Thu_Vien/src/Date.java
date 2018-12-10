public class Date
{
	private int iNgay;
	private int iThang;
	private int iNam;
	public int getiNgay()
	{
		return this.iNgay;
	}
	public void setdNgay(int Ngay)
	{
		this.iNgay = Ngay;
	}
	public int getiThang()
	{
		return this.iThang;
	}
	public void setdThang(int Thang)
	{
		this.iThang = Thang;
	}
	public int getiNam()
	{
		return this.iNam;
	}
	public void setdNam(int Nam)
	{
		this.iNam = Nam;
	}
	
	public Date()
	{
		super();
	}
	public Date(int Ngay, int Thang, int Nam)
	{
		super();
		this.iNgay=Ngay;
		this.iThang=Thang;
		this.iNam=Nam;
	}
	public static Boolean SoSanhLonHon (Date a, Date b)
    {
        if ((a.iNam > b.iNam) || (a.iNam == b.iNam && a.iThang > b.iThang) || (a.iNam == b.iNam && a.iThang == b.iThang && a.iNgay > b.iNgay))
        {
        	return true;
        }
        else 
        {
        	return false ;
        }
    }
    public static Boolean SoSanhNhoHon (Date a, Date b)
    {
        if( (a.iNam < b.iNam) || (a.iNam == b.iNam && a.iThang < b.iThang) || (a.iNam == b.iNam && a.iThang == b.iThang && a.iNgay < b.iNgay))
        {
        	return true;
        }
        else
        {
        	return false;
        }
    }
    public static Boolean SoSanhLonHonBang (Date a, Date b)
    {
       if( (a.iNam >= b.iNam) || (a.iNam == b.iNam && a.iThang >= b.iThang) || (a.iNam == b.iNam && a.iThang == b.iThang && a.iNgay >= b.iNgay))
       {
    	   return true;
       }
       else 
       {
    	   return false;
       }
    }
    public static Boolean SoSanhNhoHonBang (Date a, Date b)
    {
        if ((a.iNam <= b.iNam) || (a.iNam == b.iNam && a.iThang <= b.iThang) || (a.iNam == b.iNam && a.iThang == b.iThang && a.iNgay <= b.iNgay))
        {
        	return true;
        }
        else
        {
        	return false ;
        }
    }
    
	public static Date PlusDay (Date a, int b)
    {
		Date c = new Date();
		c.iNgay = a.iNgay;
		c.iThang = a.iThang;
		c.iNam = a.iNam;
        int t;
        t = c.iNgay + b;
        c.iThang += t / 30;
        c.iNgay = t % 30;
        if (c.iThang > 12)
        {
            c.iThang = c.iThang % 12;
            c.iNam++;
        }
        return c;
    }
	  public static Date SubDay (Date a, int b)
      {
          Date c = new Date();
          c.iNgay = a.iNgay - b;
          c.iThang = a.iThang;
          c.iNam = a.iNam;

          while (c.iNgay <= 0)
          {
              c.iNgay = c.iNgay + 30;
              c.iThang--;
          }
       
          while (c.iThang <= 0)
          {
              c.iThang = 12 - c.iThang;
              c.iNam--;
          }
          return c;
      }
	  public static int SubDate (Date a, Date b)
		{
			int SoLuongNgay = 0;
			if (a.iNam == b.iNam)
			{
				if (a.iThang == b.iThang)
				{
					SoLuongNgay = a.iNgay - b.iNgay;
				}
				else
				{
					SoLuongNgay = (30 - b.iNgay) + ((a.iThang - b.iThang - 1) * 30) + a.iNgay;
				}
			}
			else
			{
				SoLuongNgay = ((12 - b.iThang) * 30) + (30 - b.iNgay) + ((a.iThang-1) * 30) + a.iNgay + ((a.iNam - b.iNam - 1) * 365);
			}
			return SoLuongNgay;
		}
}
